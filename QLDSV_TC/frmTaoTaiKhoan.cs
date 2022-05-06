using System;
using System.Data;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class frmTaoTaiKhoan : Form
    {
        public frmTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            try
            {
                Program.KetNoi();
                cmbGiangVien.DataSource = Program.ExecSqlQuery("EXEC SP_LAYTHONGTINGIANGVIEN", Program.connStrSiteChu);
                cmbGiangVien.DisplayMember = "THONGTIN";
                cmbGiangVien.ValueMember = "MAGV";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {

        }
    }
}
