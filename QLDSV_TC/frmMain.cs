﻿using System;
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
            barMa.Caption = "Mã: " + Program.mMaGV;
            barHoTen.Caption = "Họ tên: " + Program.mHoten;
            bartenNhom.Caption = "Nhóm: " + Program.mTenNhom;
        }

        public void phanQuyen()
        {
            rbDangNhap.Visible = false; // Ẩn nút đăng nhập
            rbTaiKhoan.Visible = true; // Hiển thị tạo mới và đăng xuất
            if (Program.mTenNhom.Equals("PGV") || Program.mTenNhom.Equals("KHOA"))
            {
                rbPageNghiepVu.Visible = true;
                rbPageBaoCao.Visible = true;
                rbPGV.Visible = true;
                rbLTC.Visible = true;
                rbSV.Visible = true;
                rbBDTK.Visible = true;
            }
            else if (Program.mTenNhom.Equals("PKT"))
            {
                rbPageNghiepVu.Visible = true;
                rbPageBaoCao.Visible = true;
                rbPKT.Visible = true;
                rbDSDongHocPhi.Visible = true;
            }
            else if (Program.mTenNhom.Equals("SV"))
            {
                rbPageNghiepVu.Visible = true;
                rbDangKyMon.Visible = true;
            }
        }

        public void dangXuat()
        {
            // Reset ribbons
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

            btnTaoTaiKhoan.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

            // Reset status bar
            barMa.Caption = "Mã";
            barHoTen.Caption = "Họ tên";
            bartenNhom.Caption = "Nhóm";

            // Đóng tất cả form con
            foreach (Form frm in this.MdiChildren)
                frm.Close();

            // Xóa bộ lọc của danh sách phân mảnh
            Program.bdsDSPM.Dispose();
        }

        private void btnDongHocPhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExist(typeof(frmHocPhi));
            if (frm != null)
                frm.Activate();
            else
            {
                frmHocPhi f = new frmHocPhi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTaoTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExist(typeof(frmTaoTaiKhoan));
            if (frm != null)
                frm.Activate();
            else
            {
                frmTaoTaiKhoan f = new frmTaoTaiKhoan();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dangXuat();
        }

        private void btnDangKyMon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExist(typeof(frmDangKyMon));
            if (frm != null)
                frm.Activate();
            else
            {
                frmDangKyMon f = new frmDangKyMon();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDSLTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExist(typeof(frmDSLTC));
            if (frm != null)
                frm.Activate();
            else
            {
                frmDSLTC f = new frmDSLTC();
                f.MdiParent = this;
                f.Show();
            }
        }

        public void updateBtnTaoTaiKhoan()
        {
            if (Program.mTenNhom.Equals("SV"))
                btnTaoTaiKhoan.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void barThongTin_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnShowDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void btnLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExist(typeof(frmSinhVien));
            if (frm != null)
                frm.Activate();
            else
            {
                frmSinhVien f = new frmSinhVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Form frm = this.checkExist(typeof(frmMonHoc));
            if (frm != null)
                frm.Activate();
            else
            {
                frmMonHoc f = new frmMonHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExist(typeof(frmLopTinChi));
            if (frm != null)
                frm.Activate();
            else
            {
                frmLopTinChi f = new frmLopTinChi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDSSVDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExist(typeof(frmDSSVDK));
            if (frm != null)
                frm.Activate();
            else
            {
                frmDSSVDK f = new frmDSSVDK();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnBDLTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExist(typeof(frmXrptBDHM));
            if (frm != null)
                frm.Activate();
            else
            {
                frmXrptBDHM f = new frmXrptBDHM();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnPhieuDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExist(typeof(frmXrptBDHM));
            if (frm != null)
                frm.Activate();
            else
            {
                frmXrptBDHM f = new frmXrptBDHM();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDSDongHocPhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExist(typeof(frmXrptHP));
            if (frm != null)
                frm.Activate();
            else
            {
                frmXrptHP f = new frmXrptHP();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnBDTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExist(typeof(frmBangDiemTongKet));
            if (frm != null)
                frm.Activate();
            else
            {
                frmBangDiemTongKet f = new frmBangDiemTongKet();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void cmbPhanManh_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExist(typeof(frmDiem));
            if (frm != null)
                frm.Activate();
            else
            {
                frmDiem f = new frmDiem();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}