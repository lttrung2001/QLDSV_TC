using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
    }
}
