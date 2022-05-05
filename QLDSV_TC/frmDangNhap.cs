using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            try
            {
                Program.bdsDSPM.DataSource = Program.ExecSqlQuery("SELECT * FROM V_DS_PHANMANH", Program.connStrSiteChu);
                cmbKhoa.DataSource = Program.bdsDSPM;
                cmbKhoa.DisplayMember = "TENCN";
                cmbKhoa.ValueMember = "TENSERVER";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.State);
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Program.index = cmbKhoa.SelectedIndex;
            Program.servername = cmbKhoa.SelectedValue.ToString();
            Program.loginName = teTaiKhoan.Text;
            Program.password = teMatKhau.Text;
            Program.KetNoi(); // Mở kết nối
            // Đọc thông tin tài khoản đăng nhập
            Program.myReader = Program.ExecSqlDataReader(String.Format("EXEC SP_DANGNHAP @TENLOGIN = '{0}'", 
                                                        Program.loginName), 
                                                        Program.connectionString);
            if (Program.myReader != null)
            {
                Program.myReader.Read(); // Đọc kết quả trả về (lệnh Read tương đương với việc đọc 1 dòng)
                // Lưu các thuộc tính vào các biến trong Program.cs
                Program.mMaGV = Program.myReader["USERNAME"].ToString();
                Program.mHoten = Program.myReader["HOTEN"].ToString();
                Program.mTenNhom = Program.myReader["TENNHOM"].ToString();
                Close(); // Đóng form đăng nhập
                Program.frmChinh.hienThiStatusBar(); // Cập nhật thông tin trên status bar
                Program.frmChinh.phanQuyen(); // Phân quyền trên ứng dụng
            }
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
