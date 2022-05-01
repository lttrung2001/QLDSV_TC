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
            // TODO: This line of code loads data into the 'dS.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.dS.V_DS_PHANMANH);

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Program.connectionString = @String.Format("Data Source={0};" +
                                                    "Initial Catalog=QLDSV_TC;" +
                                                    "User ID={1};Password={2}",
                                                    cmbKhoa.SelectedValue.ToString(), 
                                                    teTaiKhoan.Text, 
                                                    teMatKhau.Text);
            try
            {
                SqlConnection cnn = new SqlConnection(Program.connectionString);
                cnn.Open(); // Mở kết nối tới site chủ
                // Execute lấy thông tin mã, họ tên, nhóm của user
                string sql = String.Format("EXEC SP_DANGNHAP @TENLOGIN = '{0}'", teTaiKhoan.Text);
                SqlCommand cmd = new SqlCommand(sql, cnn); 
                SqlDataReader reader = cmd.ExecuteReader(); // Thực thi câu lệnh sql tại kết nối cnn
                reader.Read(); // Đọc kết quả trả về (lệnh Read tương đương với việc đọc 1 dòng)
                // Lưu các thuộc tính vào các biến trong Program.cs để dùng
                Program.tenPhanManh = cmbKhoa.SelectedValue.ToString();
                Program.ma = reader["USERNAME"].ToString();
                Program.hoTen = reader["HOTEN"].ToString();
                Program.tenNhom = reader["TENNHOM"].ToString(); 
                cnn.Close(); // Đóng kết nối
                this.Close(); // Đóng form đăng nhập
                Program.frmChinh.hienThiStatusBar(); // Cập nhật thông tin trên status bar
                Program.frmChinh.phanQuyen(); // Phân quyền trên ứng dụng

            }
            catch
            {
                MessageBox.Show("Đã có lỗi xảy ra!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Program.frmChinh.Close();
        }
    }
}
