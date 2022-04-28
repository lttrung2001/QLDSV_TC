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

        private Form checkExist(Type type)
        {
            foreach (Form frm in this.MdiChildren)
                if (frm.GetType() == type)
                    return frm;
            return null;
        }

        public void hienThiStatusBar()
        {
            barMa.Caption = "Mã: " + Program.ma;
            barHoTen.Caption = "Họ tên: " + Program.hoTen;
            bartenNhom.Caption = "Nhóm: " + Program.tenNhom;
        }

        public void phanQuyen()
        {
            rbDangNhap.Visible = false; // Ẩn nút đăng nhập
            rbTaiKhoan.Visible = true; // Hiển thị tạo mới và đăng xuất
            if (Program.tenNhom.Equals("PGV") || Program.tenNhom.Equals("PKT"))
            {
                rbPageNghiepVu.Visible = true;
                rbPageBaoCao.Visible = true;
                rbPGV.Visible = true;
                rbLTC.Visible = true;
                rbSV.Visible = true;
                rbBDTK.Visible = true;
            }
            else if (Program.tenNhom.Equals("KHOA"))
            {
                rbPageNghiepVu.Visible = true;
                rbPageBaoCao.Visible = true;
                rbPKT.Visible = true;
                rbDSDongHocPhi.Visible = true;
            }
            else if (Program.tenNhom.Equals("SINHVIEN"))
            {
                rbPageNghiepVu.Visible = true;
                rbDangKyMon.Visible = true;
            }
        }

        public void dangXuat()
        {
            rbPageNghiepVu.Visible = false;
            rbPageBaoCao.Visible = false;
            rbTaiKhoan.Visible = false;
            rbDangNhap.Visible = true;
            rbPGV.Visible = false;
            rbPKT.Visible = false;
            rbDangKyMon.Visible = false;
            rbLTC.Visible = false;
            rbSV.Visible = false;
            rbDSDongHocPhi.Visible = false;
            rbBDTK.Visible = false;
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dangXuat();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            
        }

        private void barThongTin_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExist(typeof(frmDangNhap));
            if (frm != null)
                frm.Activate();
            else
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barMa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
    }
}