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
                // Kết nối site hiện tại
                if (Program.KetNoi() == 0) return; // Nếu không mở kết nối được thì dừng
                // Lấy danh sách giảng viên đưa vào combobox
                cmbGiangVien.DataSource = Program.ExecSqlQuery(String.Format("EXEC SP_LAYTHONGTINGIANGVIEN '{0}'", Program.mMaGV), Program.connectionString);
                cmbGiangVien.DisplayMember = "THONGTIN";
                cmbGiangVien.ValueMember = "MAGV";

                // Lấy danh sách nhóm quyền đưa vào combobox
                cmbTenNhom.DataSource = Program.ExecSqlQuery(String.Format("EXEC SP_LAYDANHSACHNHOMQUYEN '{0}'",Program.mTenNhom), Program.connectionString);
                cmbTenNhom.DisplayMember = "TENNHOM";
                cmbTenNhom.ValueMember = "TENNHOM";
                if (Program.mTenNhom.Equals("PGV")) cmbTenNhom.Enabled = true; // Nếu là PGV thì cho chọn nhóm để tạo TK
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            // Note: Đã xử lý tạo tài khoản trên site đang đăng nhập
            // Mở kết nối
            if (Program.KetNoi() == 0) return; // Không kết nối được ==> dừng
            int res1 = Program.ExecSqlNonQuery(String.Format("EXEC SP_TAOLOGIN '{0}','{1}','{2}','{3}'",
                                                            teTaiKhoan.Text,teMatKhau.Text,
                                                            cmbGiangVien.SelectedValue.ToString(),
                                                            cmbTenNhom.SelectedValue.ToString()),
                                            Program.connectionString);
            if (res1 == 1) MessageBox.Show("Tạo tài khoản thành công!");
            
        }
    }
}
