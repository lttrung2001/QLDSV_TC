using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void dangNhapThanhCong(SqlDataReader reader)
        {
            String username = reader["USERNAME"].ToString();
            String fullName = reader["HOTEN"].ToString();
            String role = reader["TENNHOM"].ToString();
            teTaiKhoan.Text = "";
            teMatKhau.Text = "";
            pnlDangNhap.Visible = false; // Ẩn form đăng nhập
            // Cập nhật thanh bar dưới cùng
            barMa.Caption = username;
            barHoTen.Caption = fullName;
            barVaiTro.Caption = role;
            // Enable nút tạo tài khoản và đăng xuất
            rbTaiKhoan.Visible = true;
            if (role.Equals("PGV") || role.Equals("KHOA")) // Được phép sử dụng full chức năng
            {
                rbPageNghiepVu.Visible = true;
                rbPageBaoCao.Visible = true;
                rbPKT.Visible = false;
                rbDangKyMon.Visible = false;
                // Ẩn nút danh sách đóng học phí của 1 lớp
                btnDSDongHocPhi.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            else if (role.Equals("PKT")) // Chỉ cập nhật đóng học phí
            {
                rbPageNghiepVu.Visible = true;
                rbPageBaoCao.Visible = true;
                rbPGV.Visible = false;
                rbDangKyMon.Visible = false;
                rbLTC.Visible = false;
                rbSV.Visible = false;
                // Ẩn nút bảng điểm tổng kết
                btnBDTK.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            else // Sinh viên
            {
                rbPageNghiepVu.Visible = true;
                rbPGV.Visible = false;
                rbPKT.Visible = false;
            }
        }

        private void DangXuat()
        {
            // Reset ribbon page
            rbPageNghiepVu.Visible = false;
            rbPageBaoCao.Visible = false;
            // Reset các ribbon group
            rbTaiKhoan.Visible = false; // Ẩn nút tạo tài khoản và đăng xuất
            rbPGV.Visible = true;
            rbPKT.Visible = true;
            rbDangKyMon.Visible = true;
            rbLTC.Visible = true;
            rbSV.Visible = true;
            rbLop.Visible = true;
            // Reset các nút trong ribbon group
            btnLop.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            btnSV.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            btnMonHoc.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            btnLTC.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            btnDongHocPhi.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            btnDangKyMon.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            btnDSLTC.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            btnDSSVDK.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            btnBDLTC.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            btnPhieuDiem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            btnDSDongHocPhi.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            btnBDTK.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            // Hiện form đăng nhập
            pnlDangNhap.Visible = true;
            // Reset bar
            barMa.Caption = "";
            barHoTen.Caption = "";
            barVaiTro.Caption = "";
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DangXuat();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        // TEST
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SQL sqlKetNoi = new SQL();
            try
            {
                SqlConnection cnn = sqlKetNoi.MoKetNoi(cmbKhoa.SelectedValue.ToString(), teTaiKhoan.Text, teMatKhau.Text);
                string sql = String.Format("EXEC SP_DANGNHAP @TENLOGIN = '{0}'", teTaiKhoan.Text);
                SqlCommand cmd = new SqlCommand(sql, cnn);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                dangNhapThanhCong(reader);
                cnn.Close();
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi khi đăng nhập!");
            }
        }

        private void pnlDangNhap_Paint(object sender, PaintEventArgs e)
        {

        }

        private void teMatKhau_EditValueChanged(object sender, EventArgs e)
        {

        }
        private void teMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void lblMatKhau_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbKhoa_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void frmMain_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.dS.V_DS_PHANMANH);

        }

        private void barThongTin_Click(object sender, EventArgs e)
        {

        }
    }
}