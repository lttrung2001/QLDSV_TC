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
            String currentSite = Program.servername.ToString();
            DataRowView row;
            int res = 1;
            int i = 0;
            if (cmbTenNhom.SelectedValue.ToString().Equals("PGV"))
            {
                for (i = 0; i < Program.bdsDSPM.Count; i++)
                {
                    row = Program.bdsDSPM[i] as DataRowView;
                    Program.servername = row["TENSERVER"].ToString();
                    if (Program.KetNoi() == 0) return; // Không kết nối được ==> dừng
                    // Tạo login ở site hiện tại. res lưu trạng thái execute thành công hay thất bại
                    res = Program.ExecSqlNonQuery(String.Format("EXEC SP_TAOLOGIN '{0}','{1}','{2}','{3}'",
                                                                    teTaiKhoan.Text,teMatKhau.Text,
                                                                    cmbGiangVien.SelectedValue.ToString(),
                                                                    cmbTenNhom.SelectedValue.ToString()),
                                                    Program.connectionString);
                    if (res == 0) break;
                }
            }
            else
            {
                if (Program.KetNoi() == 0) return; // Không kết nối được ==> dừng
                                                   // Tạo login ở site hiện tại. res lưu trạng thái execute thành công hay thất bại
                res = Program.ExecSqlNonQuery(String.Format("EXEC SP_TAOLOGIN '{0}','{1}','{2}','{3}'",
                                                                teTaiKhoan.Text, teMatKhau.Text,
                                                                cmbGiangVien.SelectedValue.ToString(),
                                                                cmbTenNhom.SelectedValue.ToString()),
                                                Program.connectionString);
            }
            if (res == 1)
            {
                MessageBox.Show("Tạo tài khoản thành công!");
            }
            else
            {
                if (i == Program.bdsDSPM.Count - 1)
                {
                    for (int j = 0; j < i; j++)
                    {
                        row = Program.bdsDSPM[j] as DataRowView;
                        Program.servername = row["TENSERVER"].ToString();
                        if (Program.KetNoi() == 0) return; // Không kết nối được ==> dừng
                                                           // Tạo login ở site hiện tại. res lưu trạng thái execute thành công hay thất bại
                        Program.ExecSqlNonQuery(String.Format("EXEC SP_XOALOGIN '{0}','{1}'",
                                                                        teTaiKhoan.Text,
                                                                        cmbGiangVien.SelectedValue.ToString()),
                                                        Program.connectionString);
                    }
                }
                MessageBox.Show("Tạo tài khoản thất bại!");
            }
            Program.servername = currentSite;
            Program.KetNoi();
        }
    }
}
