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
            this.btnBDTK = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barMa = new DevExpress.XtraBars.BarStaticItem();
            this.barHoTen = new DevExpress.XtraBars.BarStaticItem();
            this.barVaiTro = new DevExpress.XtraBars.BarStaticItem();
            this.rbPageTaiKhoan = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbTaiKhoan = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbPageNghiepVu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbPGV = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbPKT = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbDangKyMon = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbPageBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbLTC = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbSV = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbLop = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barThongTin = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.pnlDangNhap = new DevExpress.XtraEditors.PanelControl();
            this.lblKhoa = new DevExpress.XtraEditors.LabelControl();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.vDSPHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLDSV_TC.DS();
            this.btnDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.teMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.teTaiKhoan = new DevExpress.XtraEditors.TextEdit();
            this.lblMatKhau = new DevExpress.XtraEditors.LabelControl();
            this.lblTaiKhoan = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.v_DS_PHANMANHTableAdapter = new QLDSV_TC.DSTableAdapters.V_DS_PHANMANHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDangNhap)).BeginInit();
            this.pnlDangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTaiKhoan.Properties)).BeginInit();
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
            this.btnBDTK,
            this.barButtonItem1,
            this.barMa,
            this.barHoTen,
            this.barVaiTro});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 20;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbPageTaiKhoan,
            this.rbPageNghiepVu,
            this.rbPageBaoCao});
            this.ribbonControl1.Size = new System.Drawing.Size(1260, 183);
            this.ribbonControl1.StatusBar = this.barThongTin;
            // 
            // btnSV
            // 
            this.btnSV.Caption = "SINH VIÊN";
            this.btnSV.Id = 1;
            this.btnSV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSV.ImageOptions.Image")));
            this.btnSV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSV.ImageOptions.LargeImage")));
            this.btnSV.Name = "btnSV";
            // 
            // btnMonHoc
            // 
            this.btnMonHoc.Caption = "MÔN HỌC";
            this.btnMonHoc.Id = 2;
            this.btnMonHoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMonHoc.ImageOptions.Image")));
            this.btnMonHoc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMonHoc.ImageOptions.LargeImage")));
            this.btnMonHoc.Name = "btnMonHoc";
            // 
            // btnLTC
            // 
            this.btnLTC.Caption = "LỚP TÍN CHỈ";
            this.btnLTC.Id = 3;
            this.btnLTC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLTC.ImageOptions.Image")));
            this.btnLTC.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLTC.ImageOptions.LargeImage")));
            this.btnLTC.Name = "btnLTC";
            // 
            // btnDongHocPhi
            // 
            this.btnDongHocPhi.Caption = "ĐÓNG HỌC PHÍ";
            this.btnDongHocPhi.Id = 4;
            this.btnDongHocPhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDongHocPhi.ImageOptions.Image")));
            this.btnDongHocPhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDongHocPhi.ImageOptions.LargeImage")));
            this.btnDongHocPhi.Name = "btnDongHocPhi";
            this.btnDongHocPhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
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
            // 
            // btnTaoTaiKhoan
            // 
            this.btnTaoTaiKhoan.Caption = "TẠO MỚI";
            this.btnTaoTaiKhoan.Id = 7;
            this.btnTaoTaiKhoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoTaiKhoan.ImageOptions.Image")));
            this.btnTaoTaiKhoan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTaoTaiKhoan.ImageOptions.LargeImage")));
            this.btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            this.btnTaoTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem7_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "ĐĂNG XUẤT";
            this.btnDangXuat.Id = 8;
            this.btnDangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.ImageOptions.Image")));
            this.btnDangXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.ImageOptions.LargeImage")));
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem8_ItemClick);
            // 
            // btnDangKyMon
            // 
            this.btnDangKyMon.Caption = "ĐĂNG KÝ MÔN";
            this.btnDangKyMon.Id = 9;
            this.btnDangKyMon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangKyMon.ImageOptions.Image")));
            this.btnDangKyMon.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDangKyMon.ImageOptions.LargeImage")));
            this.btnDangKyMon.Name = "btnDangKyMon";
            this.btnDangKyMon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem9_ItemClick);
            // 
            // btnDSLTC
            // 
            this.btnDSLTC.Caption = "DANH SÁCH LỚP";
            this.btnDSLTC.Id = 10;
            this.btnDSLTC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDSLTC.ImageOptions.Image")));
            this.btnDSLTC.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDSLTC.ImageOptions.LargeImage")));
            this.btnDSLTC.Name = "btnDSLTC";
            this.btnDSLTC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem10_ItemClick);
            // 
            // btnDSSVDK
            // 
            this.btnDSSVDK.Caption = "DANH SÁCH SINH VIÊN ĐĂNG KÝ";
            this.btnDSSVDK.Id = 11;
            this.btnDSSVDK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDSSVDK.ImageOptions.Image")));
            this.btnDSSVDK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDSSVDK.ImageOptions.LargeImage")));
            this.btnDSSVDK.Name = "btnDSSVDK";
            // 
            // btnBDLTC
            // 
            this.btnBDLTC.Caption = "BẢNG ĐIỂM";
            this.btnBDLTC.Id = 12;
            this.btnBDLTC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBangDiem.ImageOptions.Image")));
            this.btnBDLTC.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBangDiem.ImageOptions.LargeImage")));
            this.btnBDLTC.Name = "btnBDLTC";
            // 
            // btnPhieuDiem
            // 
            this.btnPhieuDiem.Caption = "PHIẾU ĐIỂM";
            this.btnPhieuDiem.Id = 13;
            this.btnPhieuDiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhieuDiem.ImageOptions.Image")));
            this.btnPhieuDiem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhieuDiem.ImageOptions.LargeImage")));
            this.btnPhieuDiem.Name = "btnPhieuDiem";
            // 
            // btnDSDongHocPhi
            // 
            this.btnDSDongHocPhi.Caption = "DANH SÁCH ĐÓNG HỌC PHÍ";
            this.btnDSDongHocPhi.Id = 14;
            this.btnDSDongHocPhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDSDongHocPhi.ImageOptions.Image")));
            this.btnDSDongHocPhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDSDongHocPhi.ImageOptions.LargeImage")));
            this.btnDSDongHocPhi.Name = "btnDSDongHocPhi";
            // 
            // btnBDTK
            // 
            this.btnBDTK.Caption = "BẢNG ĐIỂM TỔNG KẾT";
            this.btnBDTK.Id = 15;
            this.btnBDTK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBDTK.ImageOptions.Image")));
            this.btnBDTK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBDTK.ImageOptions.LargeImage")));
            this.btnBDTK.Name = "btnBDTK";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 16;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barMa
            // 
            this.barMa.Id = 17;
            this.barMa.Name = "barMa";
            // 
            // barHoTen
            // 
            this.barHoTen.Id = 18;
            this.barHoTen.Name = "barHoTen";
            // 
            // barVaiTro
            // 
            this.barVaiTro.Id = 19;
            this.barVaiTro.Name = "barVaiTro";
            // 
            // rbPageTaiKhoan
            // 
            this.rbPageTaiKhoan.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbTaiKhoan});
            this.rbPageTaiKhoan.Name = "rbPageTaiKhoan";
            this.rbPageTaiKhoan.Text = "TÀI KHOẢN";
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
            // 
            // rbPKT
            // 
            this.rbPKT.ItemLinks.Add(this.btnDongHocPhi, true);
            this.rbPKT.Name = "rbPKT";
            // 
            // rbDangKyMon
            // 
            this.rbDangKyMon.ItemLinks.Add(this.btnDangKyMon);
            this.rbDangKyMon.Name = "rbDangKyMon";
            // 
            // rbPageBaoCao
            // 
            this.rbPageBaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbLTC,
            this.rbSV,
            this.rbLop});
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
            // 
            // rbSV
            // 
            this.rbSV.ItemLinks.Add(this.btnPhieuDiem);
            this.rbSV.Name = "rbSV";
            this.rbSV.Text = "SINH VIÊN";
            // 
            // rbLop
            // 
            this.rbLop.ItemLinks.Add(this.btnDSDongHocPhi);
            this.rbLop.ItemLinks.Add(this.btnBDTK);
            this.rbLop.Name = "rbLop";
            this.rbLop.Text = "LỚP";
            // 
            // barThongTin
            // 
            this.barThongTin.ItemLinks.Add(this.barMa);
            this.barThongTin.ItemLinks.Add(this.barHoTen);
            this.barThongTin.ItemLinks.Add(this.barVaiTro);
            this.barThongTin.Location = new System.Drawing.Point(0, 616);
            this.barThongTin.Name = "barThongTin";
            this.barThongTin.Ribbon = this.ribbonControl1;
            this.barThongTin.Size = new System.Drawing.Size(1260, 33);
            this.barThongTin.Click += new System.EventHandler(this.barThongTin_Click);
            // 
            // pnlDangNhap
            // 
            this.pnlDangNhap.AutoSize = true;
            this.pnlDangNhap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlDangNhap.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlDangNhap.Controls.Add(this.lblKhoa);
            this.pnlDangNhap.Controls.Add(this.cmbKhoa);
            this.pnlDangNhap.Controls.Add(this.btnDangNhap);
            this.pnlDangNhap.Controls.Add(this.teMatKhau);
            this.pnlDangNhap.Controls.Add(this.teTaiKhoan);
            this.pnlDangNhap.Controls.Add(this.lblMatKhau);
            this.pnlDangNhap.Controls.Add(this.lblTaiKhoan);
            this.pnlDangNhap.Controls.Add(this.labelControl1);
            this.pnlDangNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDangNhap.Location = new System.Drawing.Point(0, 183);
            this.pnlDangNhap.Name = "pnlDangNhap";
            this.pnlDangNhap.Size = new System.Drawing.Size(1260, 250);
            this.pnlDangNhap.TabIndex = 1;
            this.pnlDangNhap.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDangNhap_Paint);
            // 
            // lblKhoa
            // 
            this.lblKhoa.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhoa.Appearance.Options.UseFont = true;
            this.lblKhoa.Location = new System.Drawing.Point(410, 93);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(55, 23);
            this.lblKhoa.TabIndex = 9;
            this.lblKhoa.Text = "KHOA";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DataSource = this.vDSPHANMANHBindingSource;
            this.cmbKhoa.DisplayMember = "TENCN";
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(555, 90);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(400, 31);
            this.cmbKhoa.TabIndex = 8;
            this.cmbKhoa.ValueMember = "TENSERVER";
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged_1);
            // 
            // vDSPHANMANHBindingSource
            // 
            this.vDSPHANMANHBindingSource.DataMember = "V_DS_PHANMANH";
            this.vDSPHANMANHBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Appearance.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Appearance.Options.UseFont = true;
            this.btnDangNhap.Location = new System.Drawing.Point(839, 214);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(116, 29);
            this.btnDangNhap.TabIndex = 7;
            this.btnDangNhap.Text = "ĐĂNG NHẬP";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // teMatKhau
            // 
            this.teMatKhau.Location = new System.Drawing.Point(555, 178);
            this.teMatKhau.Name = "teMatKhau";
            this.teMatKhau.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teMatKhau.Properties.Appearance.Options.UseFont = true;
            this.teMatKhau.Properties.PasswordChar = '*';
            this.teMatKhau.Size = new System.Drawing.Size(400, 30);
            this.teMatKhau.TabIndex = 6;
            this.teMatKhau.EditValueChanged += new System.EventHandler(this.teMatKhau_EditValueChanged);
            // 
            // teTaiKhoan
            // 
            this.teTaiKhoan.Location = new System.Drawing.Point(555, 135);
            this.teTaiKhoan.Name = "teTaiKhoan";
            this.teTaiKhoan.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teTaiKhoan.Properties.Appearance.Options.UseFont = true;
            this.teTaiKhoan.Size = new System.Drawing.Size(400, 30);
            this.teTaiKhoan.TabIndex = 5;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.Appearance.Options.UseFont = true;
            this.lblMatKhau.Location = new System.Drawing.Point(410, 181);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(100, 23);
            this.lblMatKhau.TabIndex = 3;
            this.lblMatKhau.Text = "MẬT KHẨU";
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaiKhoan.Appearance.Options.UseFont = true;
            this.lblTaiKhoan.Location = new System.Drawing.Point(410, 138);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(105, 23);
            this.lblTaiKhoan.TabIndex = 2;
            this.lblTaiKhoan.Text = "TÀI KHOẢN";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(2, 2);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 100, 3, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Padding = new System.Windows.Forms.Padding(0, 25, 0, 25);
            this.labelControl1.Size = new System.Drawing.Size(1256, 85);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ĐĂNG NHẬP";
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // frmMain
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 649);
            this.Controls.Add(this.barThongTin);
            this.Controls.Add(this.pnlDangNhap);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDangNhap)).EndInit();
            this.pnlDangNhap.ResumeLayout(false);
            this.pnlDangNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTaiKhoan.Properties)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnBDTK;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbSV;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbLop;
        private DevExpress.XtraEditors.PanelControl pnlDangNhap;
        private DevExpress.XtraEditors.SimpleButton btnDangNhap;
        private DevExpress.XtraEditors.TextEdit teMatKhau;
        private DevExpress.XtraEditors.TextEdit teTaiKhoan;
        private DevExpress.XtraEditors.LabelControl lblMatKhau;
        private DevExpress.XtraEditors.LabelControl lblTaiKhoan;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarStaticItem barMa;
        private DevExpress.XtraBars.BarStaticItem barHoTen;
        private DevExpress.XtraBars.BarStaticItem barVaiTro;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar barThongTin;
        private DevExpress.XtraEditors.LabelControl lblKhoa;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private DS dS;
        private System.Windows.Forms.BindingSource vDSPHANMANHBindingSource;
        private DSTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
    }
}