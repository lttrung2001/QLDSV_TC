using DevExpress.XtraGrid.Views.Base;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class frmDangKyMon : Form
    {
        public frmDangKyMon()
        {
            InitializeComponent();
        }

        private void frmDangKyMon_Load(object sender, EventArgs e)
        {
            this.taNienKhoa.Connection.ConnectionString = Program.connectionString;
            this.taNienKhoa.Fill(this.dS.NIENKHOA);

            cmbNienKhoa.DataSource = bdsNienKhoa;
            cmbNienKhoa.ValueMember = "NIENKHOA";
            cmbNienKhoa.DisplayMember = "NIENKHOA";

            cmbHocKy.SelectedIndex = 0;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (teMaSV.Text.Equals(""))
            {
                MessageBox.Show("Không để trống mã sinh viên!");
                return;
            }
            Program.myReader.Close();
            Program.myReader = Program.ExecSqlDataReader(String.Format("EXEC SP_LAYTHONGTINSINHVIEN '{0}'", teMaSV.Text), 
                                                            Program.connectionString);
            if (Program.myReader.HasRows)
            {
                Program.myReader.Read();
                teHoTen.Text = Program.myReader["HOTEN"].ToString();
                teMaLop.Text = Program.myReader["MALOP"].ToString();

                pnlThongTinSV.Enabled = false;
                pnlLocLopTinChi.Enabled = true;
            }
            else
            {
                MessageBox.Show("Sinh viên đã nghỉ học hoặc không tồn tại!");
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            try
            {
                sP_LOCLTCTableAdapter.Connection.ConnectionString = Program.connectionString;
                sP_LOCLTCTableAdapter.Fill(dS.SP_LOCLTC, teMaSV.Text, cmbNienKhoa.Text, int.Parse(cmbHocKy.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi lọc lớp tín chỉ: " + ex.Message);
                return;
            }
            if (sP_LOCLTCBindingSource.Count == 0)
            {
                MessageBox.Show("Không có lớp tín chỉ nào được mở trong kỳ này!");
                sP_LOCLTCGridControl.Enabled =
                sP_LAY_DSLTC_SVDKGridControl.Enabled =
                groupBox1.Enabled =
                panel1.Enabled = false;
                return;
            }
            else
            {
                try
                {
                    sP_LAY_DSLTC_SVDKTableAdapter.Connection.ConnectionString = Program.connectionString;
                    sP_LAY_DSLTC_SVDKTableAdapter.Fill(dS.SP_LAY_DSLTC_SVDK, teMaSV.Text, cmbNienKhoa.Text, int.Parse(cmbHocKy.Text));
                }
                 catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi lấy danh sách môn học sinh viên đăng ký: " + ex.Message);
                    return;
                }
                sP_LOCLTCGridControl.Enabled =
                sP_LAY_DSLTC_SVDKGridControl.Enabled =
                groupBox1.Enabled =
                panel1.Enabled = true;
                if (sP_LAY_DSLTC_SVDKBindingSource.Count == 0) hủyĐăngKýToolStripMenuItem.Enabled = false;
                else hủyĐăngKýToolStripMenuItem.Enabled = true;
            }
        }

        private void btnThoatDangKy_Click(object sender, EventArgs e)
        {
            pnlThongTinSV.Enabled = true;
            pnlLocLopTinChi.Enabled = 
                sP_LOCLTCGridControl.Enabled = 
                sP_LAY_DSLTC_SVDKGridControl.Enabled = 
                groupBox1.Enabled =
                panel1.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Lưu dữ liệu trước khi thoát form
            Close();
        }

        private void gridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (sP_LOCLTCBindingSource.Current == null) return;
            String huy = ((DataRowView)sP_LOCLTCBindingSource.Current)["HUYDANGKY"].ToString();
            if (huy.Equals("False"))
                button1.Text = "Hủy đăng ký";
            else
                button1.Text = "Đăng ký";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRowView currentRow = (DataRowView)sP_LOCLTCBindingSource.Current;
            String huy = currentRow["HUYDANGKY"].ToString();
            if (huy.Equals("False")) // Ban đầu đã đăng ký
            {
                if (Program.ExecSqlNonQuery("EXEC SP_KIEMTRALTCDANHAPDIEM " + currentRow["MALTC"].ToString(), Program.connectionString) == 1)
                {
                    currentRow["HUYDANGKY"] = true; // Set lại trạng thái là Hủy
                    button1.Text = "Đăng ký";
                    sP_LAY_DSLTC_SVDKBindingSource.RemoveAt(kiemTraTrungMon(currentRow["MAMH"].ToString()));
                }
            }
            else // Ban đầu chưa đăng ký hoặc đang hủy
            {
                // Check đã đăng ký môn này?
                if (kiemTraTrungMon(currentRow["MAMH"].ToString()) != -1)
                    MessageBox.Show("Bạn đã đăng ký môn này rồi!");
                else // Không trùng
                {
                    if (Program.ExecSqlNonQuery("EXEC SP_KIEMTRALTCDANHAPDIEM " + currentRow["MALTC"].ToString(), Program.connectionString) == 1)
                    {
                        currentRow["HUYDANGKY"] = false;
                        button1.Text = "Hủy đăng ký";
                        sP_LAY_DSLTC_SVDKBindingSource.AddNew();
                        DataRowView newRow = ((DataRowView)sP_LAY_DSLTC_SVDKBindingSource.Current);
                        newRow["MALTC"] = currentRow["MALTC"];
                        newRow["MAMH"] = currentRow["MAMH"];
                        newRow["TENMH"] = currentRow["TENMH"];
                        newRow["NHOM"] = currentRow["NHOM"];
                        newRow["HOTENGV"] = currentRow["HOTENGV"];
                    }
                }
            }
            if (sP_LAY_DSLTC_SVDKBindingSource.Count == 0) hủyĐăngKýToolStripMenuItem.Enabled = false;
            else hủyĐăngKýToolStripMenuItem.Enabled = true;
        }
        private int kiemTraTrungMon(String maMon)
        {
            DataRowView row;
            for (int i = 0; i < sP_LAY_DSLTC_SVDKBindingSource.Count; i++)
            {
                row = (DataRowView)sP_LAY_DSLTC_SVDKBindingSource[i];
                if (maMon.Equals(row["MAMH"].ToString()))
                    return i; // Trung thi tra ve vi tri
            }
            return -1; // Khong trung
        }

        private void cmbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MALTC", typeof(int));

            DataRowView tmp;
            for (int i = 0; i < sP_LAY_DSLTC_SVDKBindingSource.Count; i++)
            {
                tmp = ((DataRowView)sP_LAY_DSLTC_SVDKBindingSource[i]);
                dt.Rows.Add(int.Parse(tmp["MALTC"].ToString()));
            }

            SqlParameter param = new SqlParameter();
            param.SqlDbType = SqlDbType.Structured;
            param.TypeName = "dbo.TYPE_CAPNHATDANGKY";
            param.ParameterName = "@DK";
            param.Value = dt;

            SqlParameter param2 = new SqlParameter();
            param2.SqlDbType = SqlDbType.NChar;
            param2.ParameterName = "@MASV";
            param2.Value = teMaSV.Text;

            Program.KetNoi();

            SqlCommand cmd = new SqlCommand("SP_CAPNHATDANGKY", Program.conn);
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(param);
            cmd.Parameters.Add(param2);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ghi thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ghi thất bại: " + ex.Message);
            }
        }

        private void hủyĐăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRowView currentRow = ((DataRowView)sP_LAY_DSLTC_SVDKBindingSource.Current);
            if (currentRow["HUYLOP"].ToString().Equals("True")) MessageBox.Show("Lớp này đã hủy. Không thể hủy đăng ký!");
            else
            {
                if (Program.ExecSqlNonQuery("EXEC SP_KIEMTRALTCDANHAPDIEM " + currentRow["MALTC"].ToString(), Program.connectionString) == 1)
                {
                    DialogResult msg = MessageBox.Show("Bạn có chắc chắn muốn hủy đăng ký?", "", MessageBoxButtons.YesNo);
                    if (msg == DialogResult.Yes)
                        sP_LAY_DSLTC_SVDKBindingSource.RemoveCurrent();
                }
                if (sP_LAY_DSLTC_SVDKBindingSource.Count == 0) hủyĐăngKýToolStripMenuItem.Enabled = false;
                else hủyĐăngKýToolStripMenuItem.Enabled = true;
            }
        }
    }
}
