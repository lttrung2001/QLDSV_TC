namespace QLDSV_TC
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnSV = new DevExpress.XtraBars.BarButtonItem();
            this.btnMonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnLTC = new DevExpress.XtraBars.BarButtonItem();
            this.btnDongHocPhi = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.btnLop = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaoTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangKyMon = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSLTC = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSSVDK = new DevExpress.XtraBars.BarButtonItem();
            this.btnBDLTC = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhieuDiem = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSDongHocPhi = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barMa = new DevExpress.XtraBars.BarStaticItem();
            this.barHoTen = new DevExpress.XtraBars.BarStaticItem();
            this.bartenNhom = new DevExpress.XtraBars.BarStaticItem();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnShowDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnBDTK = new DevExpress.XtraBars.BarButtonItem();
            this.rbPageTaiKhoan = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbDangNhap = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbTaiKhoan = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbPageNghiepVu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbPGV = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbPKT = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbDangKyMon = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbPageBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbLTC = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbSV = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbDSDongHocPhi = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbBDTK = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barThongTin = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.dS = new QLDSV_TC.DS();
            this.btnThoatCT = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.AllowMinimizeRibbon = false;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnSV,
            this.btnMonHoc,
            this.btnLTC,
            this.btnDongHocPhi,
            this.barButtonItem5,
            this.btnLop,
            this.btnTaoTaiKhoan,
            this.btnDangXuat,
            this.btnDangKyMon,
            this.btnDSLTC,
            this.btnDSSVDK,
            this.btnBDLTC,
            this.btnPhieuDiem,
            this.btnDSDongHocPhi,
            this.barButtonItem1,
            this.barMa,
            this.barHoTen,
            this.bartenNhom,
            this.btnDangNhap,
            this.barButtonItem2,
            this.btnShowDangNhap,
            this.btnBDTK,
            this.btnThoatCT});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 25;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbPageTaiKhoan,
            this.rbPageNghiepVu,
            this.rbPageBaoCao});
            this.ribbonControl1.Size = new System.Drawing.Size(1260, 183);
            this.ribbonControl1.StatusBar = this.barThongTin;
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // btnSV
            // 
            this.btnSV.Caption = "SINH VIÊN";
            this.btnSV.Id = 1;
            this.btnSV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSV.ImageOptions.Image")));
            this.btnSV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSV.ImageOptions.LargeImage")));
            this.btnSV.Name = "btnSV";
            this.btnSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSV_ItemClick);
            // 
            // btnMonHoc
            // 
            this.btnMonHoc.Caption = "MÔN HỌC";
            this.btnMonHoc.Id = 2;
            this.btnMonHoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMonHoc.ImageOptions.Image")));
            this.btnMonHoc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMonHoc.ImageOptions.LargeImage")));
            this.btnMonHoc.Name = "btnMonHoc";
            this.btnMonHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMonHoc_ItemClick);
            // 
            // btnLTC
            // 
            this.btnLTC.Caption = "LỚP TÍN CHỈ";
            this.btnLTC.Id = 3;
            this.btnLTC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLTC.ImageOptions.Image")));
            this.btnLTC.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLTC.ImageOptions.LargeImage")));
            this.btnLTC.Name = "btnLTC";
            this.btnLTC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLTC_ItemClick);
            // 
            // btnDongHocPhi
            // 
            this.btnDongHocPhi.Caption = "ĐÓNG HỌC PHÍ";
            this.btnDongHocPhi.Id = 4;
            this.btnDongHocPhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDongHocPhi.ImageOptions.Image")));
            this.btnDongHocPhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDongHocPhi.ImageOptions.LargeImage")));
            this.btnDongHocPhi.Name = "btnDongHocPhi";
            this.btnDongHocPhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDongHocPhi_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "TẠO TÀI KHOẢN";
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonItem5.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // btnLop
            // 
            this.btnLop.Caption = "LỚP";
            this.btnLop.Id = 6;
            this.btnLop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLop.ImageOptions.Image")));
            this.btnLop.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLop.ImageOptions.LargeImage")));
            this.btnLop.Name = "btnLop";
            this.btnLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLop_ItemClick);
            // 
            // btnTaoTaiKhoan
            // 
            this.btnTaoTaiKhoan.Caption = "TẠO MỚI";
            this.btnTaoTaiKhoan.Id = 7;
            this.btnTaoTaiKhoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoTaiKhoan.ImageOptions.Image")));
            this.btnTaoTaiKhoan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTaoTaiKhoan.ImageOptions.LargeImage")));
            this.btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            this.btnTaoTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoTaiKhoan_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "ĐĂNG XUẤT";
            this.btnDangXuat.Id = 8;
            this.btnDangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.ImageOptions.Image")));
            this.btnDangXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.ImageOptions.LargeImage")));
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // btnDangKyMon
            // 
            this.btnDangKyMon.Caption = "ĐĂNG KÝ MÔN";
            this.btnDangKyMon.Id = 9;
            this.btnDangKyMon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangKyMon.ImageOptions.Image")));
            this.btnDangKyMon.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDangKyMon.ImageOptions.LargeImage")));
            this.btnDangKyMon.Name = "btnDangKyMon";
            this.btnDangKyMon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangKyMon_ItemClick);
            // 
            // btnDSLTC
            // 
            this.btnDSLTC.Caption = "DANH SÁCH LỚP";
            this.btnDSLTC.Id = 10;
            this.btnDSLTC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDSLTC.ImageOptions.Image")));
            this.btnDSLTC.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDSLTC.ImageOptions.LargeImage")));
            this.btnDSLTC.Name = "btnDSLTC";
            this.btnDSLTC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDSLTC_ItemClick);
            // 
            // btnDSSVDK
            // 
            this.btnDSSVDK.Caption = "DANH SÁCH SINH VIÊN ĐĂNG KÝ";
            this.btnDSSVDK.Id = 11;
            this.btnDSSVDK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDSSVDK.ImageOptions.Image")));
            this.btnDSSVDK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDSSVDK.ImageOptions.LargeImage")));
            this.btnDSSVDK.Name = "btnDSSVDK";
            this.btnDSSVDK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDSSVDK_ItemClick);
            // 
            // btnBDLTC
            // 
            this.btnBDLTC.Caption = "BẢNG ĐIỂM";
            this.btnBDLTC.Id = 12;
            this.btnBDLTC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBDLTC.ImageOptions.Image")));
            this.btnBDLTC.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBDLTC.ImageOptions.LargeImage")));
            this.btnBDLTC.Name = "btnBDLTC";
            this.btnBDLTC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBDLTC_ItemClick);
            // 
            // btnPhieuDiem
            // 
            this.btnPhieuDiem.Caption = "PHIẾU ĐIỂM";
            this.btnPhieuDiem.Id = 13;
            this.btnPhieuDiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhieuDiem.ImageOptions.Image")));
            this.btnPhieuDiem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhieuDiem.ImageOptions.LargeImage")));
            this.btnPhieuDiem.Name = "btnPhieuDiem";
            this.btnPhieuDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhieuDiem_ItemClick);
            // 
            // btnDSDongHocPhi
            // 
            this.btnDSDongHocPhi.Caption = "DANH SÁCH ĐÓNG HỌC PHÍ";
            this.btnDSDongHocPhi.Id = 14;
            this.btnDSDongHocPhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDSDongHocPhi.ImageOptions.Image")));
            this.btnDSDongHocPhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDSDongHocPhi.ImageOptions.LargeImage")));
            this.btnDSDongHocPhi.Name = "btnDSDongHocPhi";
            this.btnDSDongHocPhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDSDongHocPhi_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 16;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barMa
            // 
            this.barMa.Caption = "Mã";
            this.barMa.Id = 17;
            this.barMa.Name = "barMa";
            this.barMa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barMa_ItemClick);
            // 
            // barHoTen
            // 
            this.barHoTen.Caption = "Họ tên";
            this.barHoTen.Id = 18;
            this.barHoTen.Name = "barHoTen";
            // 
            // bartenNhom
            // 
            this.bartenNhom.Caption = "Nhóm";
            this.bartenNhom.Id = 19;
            this.bartenNhom.Name = "bartenNhom";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "ĐĂNG NHẬP";
            this.btnDangNhap.Id = 20;
            this.btnDangNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.ImageOptions.Image")));
            this.btnDangNhap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.ImageOptions.LargeImage")));
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 21;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btnShowDangNhap
            // 
            this.btnShowDangNhap.Caption = "ĐĂNG NHẬP";
            this.btnShowDangNhap.Id = 22;
            this.btnShowDangNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnShowDangNhap.ImageOptions.Image")));
            this.btnShowDangNhap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnShowDangNhap.ImageOptions.LargeImage")));
            this.btnShowDangNhap.Name = "btnShowDangNhap";
            this.btnShowDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnShowDangNhap_ItemClick);
            // 
            // btnBDTK
            // 
            this.btnBDTK.Caption = "BẢNG ĐIỂM TỔNG KẾT";
            this.btnBDTK.Id = 23;
            this.btnBDTK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBDTK.ImageOptions.Image")));
            this.btnBDTK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBDTK.ImageOptions.LargeImage")));
            this.btnBDTK.Name = "btnBDTK";
            this.btnBDTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBDTK_ItemClick);
            // 
            // rbPageTaiKhoan
            // 
            this.rbPageTaiKhoan.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbDangNhap,
            this.rbTaiKhoan});
            this.rbPageTaiKhoan.Name = "rbPageTaiKhoan";
            this.rbPageTaiKhoan.Text = "TÀI KHOẢN";
            // 
            // rbDangNhap
            // 
            this.rbDangNhap.ItemLinks.Add(this.btnShowDangNhap);
            this.rbDangNhap.ItemLinks.Add(this.btnThoatCT);
            this.rbDangNhap.Name = "rbDangNhap";
            // 
            // rbTaiKhoan
            // 
            this.rbTaiKhoan.ItemLinks.Add(this.btnTaoTaiKhoan);
            this.rbTaiKhoan.ItemLinks.Add(this.btnDangXuat);
            this.rbTaiKhoan.Name = "rbTaiKhoan";
            this.rbTaiKhoan.Visible = false;
            // 
            // rbPageNghiepVu
            // 
            this.rbPageNghiepVu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbPGV,
            this.rbPKT,
            this.rbDangKyMon});
            this.rbPageNghiepVu.Name = "rbPageNghiepVu";
            this.rbPageNghiepVu.Text = "NGHIỆP VỤ";
            this.rbPageNghiepVu.Visible = false;
            // 
            // rbPGV
            // 
            this.rbPGV.ItemLinks.Add(this.btnLop);
            this.rbPGV.ItemLinks.Add(this.btnSV);
            this.rbPGV.ItemLinks.Add(this.btnMonHoc);
            this.rbPGV.ItemLinks.Add(this.btnLTC);
            this.rbPGV.Name = "rbPGV";
            this.rbPGV.Visible = false;
            // 
            // rbPKT
            // 
            this.rbPKT.ItemLinks.Add(this.btnDongHocPhi, true);
            this.rbPKT.Name = "rbPKT";
            this.rbPKT.Visible = false;
            // 
            // rbDangKyMon
            // 
            this.rbDangKyMon.ItemLinks.Add(this.btnDangKyMon);
            this.rbDangKyMon.Name = "rbDangKyMon";
            this.rbDangKyMon.Visible = false;
            // 
            // rbPageBaoCao
            // 
            this.rbPageBaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbLTC,
            this.rbSV,
            this.rbDSDongHocPhi,
            this.rbBDTK});
            this.rbPageBaoCao.Name = "rbPageBaoCao";
            this.rbPageBaoCao.Text = "BÁO CÁO";
            this.rbPageBaoCao.Visible = false;
            // 
            // rbLTC
            // 
            this.rbLTC.ItemLinks.Add(this.btnDSLTC);
            this.rbLTC.ItemLinks.Add(this.btnDSSVDK);
            this.rbLTC.ItemLinks.Add(this.btnBDLTC);
            this.rbLTC.Name = "rbLTC";
            this.rbLTC.Text = "LỚP TÍN CHỈ";
            this.rbLTC.Visible = false;
            // 
            // rbSV
            // 
            this.rbSV.ItemLinks.Add(this.btnPhieuDiem);
            this.rbSV.Name = "rbSV";
            this.rbSV.Text = "SINH VIÊN";
            this.rbSV.Visible = false;
            // 
            // rbDSDongHocPhi
            // 
            this.rbDSDongHocPhi.ItemLinks.Add(this.btnDSDongHocPhi);
            this.rbDSDongHocPhi.Name = "rbDSDongHocPhi";
            this.rbDSDongHocPhi.Text = "LỚP";
            this.rbDSDongHocPhi.Visible = false;
            // 
            // rbBDTK
            // 
            this.rbBDTK.ItemLinks.Add(this.btnBDTK);
            this.rbBDTK.Name = "rbBDTK";
            this.rbBDTK.Text = "LỚP";
            this.rbBDTK.Visible = false;
            // 
            // barThongTin
            // 
            this.barThongTin.ItemLinks.Add(this.barMa);
            this.barThongTin.ItemLinks.Add(this.barHoTen);
            this.barThongTin.ItemLinks.Add(this.bartenNhom);
            this.barThongTin.Location = new System.Drawing.Point(0, 616);
            this.barThongTin.Name = "barThongTin";
            this.barThongTin.Ribbon = this.ribbonControl1;
            this.barThongTin.Size = new System.Drawing.Size(1260, 33);
            this.barThongTin.Click += new System.EventHandler(this.barThongTin_Click);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnThoatCT
            // 
            this.btnThoatCT.Caption = "THOÁT CHƯƠNG TRÌNH";
            this.btnThoatCT.Id = 24;
            this.btnThoatCT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoatCT.ImageOptions.Image")));
            this.btnThoatCT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoatCT.ImageOptions.LargeImage")));
            this.btnThoatCT.Name = "btnThoatCT";
            this.btnThoatCT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoatCT_ItemClick);
            // 
            // frmMain
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 649);
            this.Controls.Add(this.barThongTin);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmMain";
            this.Text = "PHẦN MỀM QUẢN LÝ ĐIỂM SINH VIÊN HỆ TÍN CHỈ - PTITHCM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnSV;
        private DevExpress.XtraBars.BarButtonItem btnMonHoc;
        private DevExpress.XtraBars.BarButtonItem btnLTC;
        private DevExpress.XtraBars.BarButtonItem btnDongHocPhi;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbPageNghiepVu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbPGV;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbPKT;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbPageBaoCao;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem btnLop;
        private DevExpress.XtraBars.BarButtonItem btnTaoTaiKhoan;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbPageTaiKhoan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.BarButtonItem btnDangKyMon;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbDangKyMon;
        private DevExpress.XtraBars.BarButtonItem btnDSLTC;
        private DevExpress.XtraBars.BarButtonItem btnDSSVDK;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbLTC;
        private DevExpress.XtraBars.BarButtonItem btnBDLTC;
        private DevExpress.XtraBars.BarButtonItem btnPhieuDiem;
        private DevExpress.XtraBars.BarButtonItem btnDSDongHocPhi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbSV;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbDSDongHocPhi;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarStaticItem barMa;
        private DevExpress.XtraBars.BarStaticItem barHoTen;
        private DevExpress.XtraBars.BarStaticItem bartenNhom;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar barThongTin;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnShowDangNhap;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbDangNhap;
        private DevExpress.XtraBars.BarButtonItem btnBDTK;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbBDTK;
        private DS dS;
        private DevExpress.XtraBars.BarButtonItem btnThoatCT;
    }
}