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
                DataTable dt = Program.ExecSqlQuery("SELECT * FROM GIANGVIEN", Program.connectionString);
                cmbGiangVien.DataSource = dt;
                cmbGiangVien.DisplayMember = "MAGV";
                cmbGiangVien.ValueMember = "MAGV";
                // Họ tên
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
