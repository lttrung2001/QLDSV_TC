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
                MessageBox.Show("Mã sinh viên không tồn tại!");
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            try
            {
                sP_LOCLTCTableAdapter.Connection.ConnectionString = Program.connectionString;
                sP_LOCLTCTableAdapter.Fill(dS.SP_LOCLTC, teMaSV.Text, cmbNienKhoa.Text, int.Parse(cmbHocKy.Text));

                sP_LAY_DSLTC_SVDKTableAdapter.Connection.ConnectionString = Program.connectionString;
                sP_LAY_DSLTC_SVDKTableAdapter.Fill(dS.SP_LAY_DSLTC_SVDK, teMaSV.Text, cmbNienKhoa.Text, int.Parse(cmbHocKy.Text));

                sP_LOCLTCGridControl.Enabled = sP_LAY_DSLTC_SVDKGridControl.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi lọc lớp tín chỉ: " + ex.Message);
            }
        }

        private void btnThoatDangKy_Click(object sender, EventArgs e)
        {
            pnlThongTinSV.Enabled = true;
            pnlLocLopTinChi.Enabled = sP_LOCLTCGridControl.Enabled = sP_LAY_DSLTC_SVDKGridControl.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Lưu dữ liệu trước khi thoát form
            Close();
        }
    }
}
