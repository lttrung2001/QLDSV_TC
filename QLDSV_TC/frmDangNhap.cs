using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class frmDangNhap : Form
    {
        private SqlConnection conn = new SqlConnection();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private bool ketNoiSiteChu()
        {
            if (conn != null || conn.State == ConnectionState.Open)
                conn.Close();
            try
            {
                conn.ConnectionString = "Data Source=DESKTOP-4UNL892\\SERVER0;Initial Catalog=QLDSV_TC;Integrated Security=True";
                conn.Open();
                return true;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối CSDL. Vui lòng xem lại tên server và chuỗi kết nối!");
                return false;
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable(); // Dùng để lưu dữ liệu
            if (ketNoiSiteChu()) // Kết nối với site chủ để lấy danh sách phân mảnh
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM V_DS_PHANMANH", conn);
                    da.Fill(dt);
                    conn.Close(); // Đóng kết nối
                    Program.bdsDSPM.DataSource = dt;
                    cmbKhoa.DataSource = Program.bdsDSPM;
                    cmbKhoa.DisplayMember = "TENCN";
                    cmbKhoa.ValueMember = "TENSERVER";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Program.frmChinh.Close();
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
