using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class frmDiem : DevExpress.XtraEditors.XtraForm
    {
        string maltc = "";
        DataTable tbDiem;
        public frmDiem()
        {
            InitializeComponent();
            if (Program.mTenNhom.Equals("PGV")) cmbKhoa.Enabled = true;
        }

        private void frmDiem_Load(object sender, EventArgs e)
        {
            try
            {
                // Kết nối site hiện tại
                if (Program.KetNoi() == 0) return; // Nếu không mở kết nối được thì dừng


                cmbKhoa.DataSource = Program.bdsDSPM;
                cmbKhoa.DisplayMember = "TENCN";
                cmbKhoa.ValueMember = "TENSERVER";
                // Lấy danh sách giảng viên đưa vào combobox
                cmbNienKhoa.DataSource = Program.ExecSqlQuery("EXEC GetNienKhoa", Program.connectionString);
                cmbNienKhoa.DisplayMember = "NIENKHOA";
                cmbNienKhoa.ValueMember = "NIENKHOA";

                // Lấy danh sách nhóm quyền đưa vào combobox
                cmbHocKi.DataSource = Program.ExecSqlQuery(String.Format("EXEC GetAllHocKy '{0}'", cmbNienKhoa.Text), Program.connectionString);
                cmbHocKi.DisplayMember = "HOCKY";
                cmbHocKi.ValueMember = "HOCKY";
            }
            catch (Exception ex)

            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btnHienThiLTC_Click(object sender, EventArgs e)
        {
            string nk = cmbNienKhoa.Text.Trim();
            if (nk == "") return;

            int hk;
            int.TryParse(cmbHocKi.Text, out hk);
            if (hk == 0) return;
            try
            {
                SP_LAY_DS_LTCTableAdapter.Connection.ConnectionString = Program.connectionString;
                this.SP_LAY_DS_LTCTableAdapter.Fill(this.DS.SP_LAY_DS_LTC, nk, hk);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Đã xảy ra lỗi khi tải lớp tín chỉ!\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            gcDiem.DataSource = null;
            btnStart.Enabled = (bdsDSLTC.Count > 0);
            btnGhi.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            gcDiem.Enabled = true;
            gcLTC.Enabled = false;
            maltc = ((DataRowView)bdsDSLTC[bdsDSLTC.Position])["MALTC"].ToString();
            string strLenh = "EXEC SP_LAY_DSSV_DANGKY " + maltc;
            tbDiem = Program.ExecSqlQuery(strLenh, Program.connectionString);
            gcDiem.DataSource = tbDiem;
            btnGhi.Enabled = tbDiem.Rows.Count > 0;
            cmbNienKhoa.Enabled = cmbHocKi.Enabled = btnHienThiLTC.Enabled = btnStart.Enabled = false;
            btnHuyNhapDiem.Enabled = btnGhi.Enabled = true;

        }

        private void btnHuyNhapDiem_Click(object sender, EventArgs e)
        {
            bdsDSLTC.CancelEdit();
            gcDiem.DataBindings.Clear();
            gcDiem.Enabled = false;
            gcLTC.Enabled = true;
            cmbNienKhoa.Enabled = cmbHocKi.Enabled = btnHienThiLTC.Enabled = btnStart.Enabled = true;
            btnHuyNhapDiem.Enabled = btnGhi.Enabled = false;
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MALTC", typeof(int));
            dt.Columns.Add("MASV", typeof(string));
            dt.Columns.Add("DIEM_CC", typeof(int));
            dt.Columns.Add("DIEM_GK", typeof(float));
            dt.Columns.Add("DIEM_CK", typeof(float));
            int intmaltc = int.Parse(maltc);
            for (int i = 0; i < tbDiem.Rows.Count; i++)
            {
                dt.Rows.Add(intmaltc, tbDiem.Rows[i]["MASV"], tbDiem.Rows[i]["DIEM_CC"],
                    tbDiem.Rows[i]["DIEM_GK"], tbDiem.Rows[i]["DIEM_CK"]);
            }

            SqlParameter para = new SqlParameter();
            para.SqlDbType = SqlDbType.Structured;
            para.TypeName = "dbo.TYPE_DANGKY";
            para.ParameterName = "@DIEMTHI";
            para.Value = dt;
            if (Program.KetNoi() == 0) return;

            SqlCommand Sqlcmd = new SqlCommand("SP_UPDATE_DIEM", Program.conn);
            Sqlcmd.Parameters.Clear();
            Sqlcmd.CommandType = CommandType.StoredProcedure;
            try
            {
                Sqlcmd.Parameters.Add(para);
                Sqlcmd.ExecuteNonQuery();
                XtraMessageBox.Show("Đã ghi toàn bộ điểm vào cơ sở dữ liệu!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Đã xảy ra lỗi khi nhập điểm!\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnHuyNhapDiem_Click(sender, e);
        }
        private void gvDiem_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.FocusedColumn.FieldName == "DIEM_CC")
            {
                if (string.IsNullOrEmpty(e.Value as string))
                    return;
                int diem;
                try
                {
                    diem = int.Parse(e.Value as string);
                }
                catch
                {
                    e.Valid = false;
                    e.ErrorText = "Điểm chuyên cần phải là số nguyên từ 0 đến 10!";
                    return;
                }
                if (diem < 0 || diem > 10)
                {
                    e.Valid = false;
                    e.ErrorText = "Điểm chuyên cần phải là số nguyên từ 0 đến 10!";
                    return;
                }
            }
            else if (view.FocusedColumn.FieldName == "DIEM_GK")
            {
                if (string.IsNullOrEmpty(e.Value as string))
                    return;
                float diem;
                try
                {
                    diem = float.Parse(e.Value as string);
                }
                catch
                {
                    e.Valid = false;
                    e.ErrorText = "Điểm giữa kỳ phải là số thực từ 0 đến 10!";
                    return;
                }
                if (diem < 0 || diem > 10)
                {
                    e.Valid = false;
                    e.ErrorText = "Điểm giữa kỳ phải là số thực từ 0 đến 10!";
                    return;
                }
                e.Value = Math.Round(diem * 2, MidpointRounding.AwayFromZero) / 2;
            }
            else if (view.FocusedColumn.FieldName == "DIEM_CK")
            {
                if (string.IsNullOrEmpty(e.Value as string))
                    return;
                float diem;
                try
                {
                    diem = float.Parse(e.Value as string);
                }
                catch
                {
                    e.Valid = false;
                    e.ErrorText = "Điểm cuối kỳ phải là số thực từ 0 đến 10!";
                    return;
                }
                if (diem < 0 || diem > 10)
                {
                    e.Valid = false;
                    e.ErrorText = "Điểm cuối kỳ phải là số thực từ 0 đến 10!";
                    return;
                }
                e.Value = Math.Round(diem * 2, MidpointRounding.AwayFromZero) / 2;
            }
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue == null) return; // Dùng để fix lỗi khi nhấn nút thoát (NULL)
            if (cmbKhoa.SelectedValue.ToString().Equals(Program.servername)) return; // Chọn lại khoa hiện tại thì return
            else // Khoa được chọn khác với khoa hiện tại
            {
                Program.servername = cmbKhoa.SelectedValue.ToString();
                if (Program.KetNoi() == 0) return; // Không kết nối được thì dừng
                try
                {
                    frmDiem_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
            }
        }
    }
}