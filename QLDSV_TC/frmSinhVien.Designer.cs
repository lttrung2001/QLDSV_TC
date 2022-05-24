namespace QLDSV_TC
{
    partial class frmSinhVien
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
            System.Windows.Forms.Label lblMaLop;
            System.Windows.Forms.Label lblTenLop;
            System.Windows.Forms.Label lblKhoaHoc;
            System.Windows.Forms.Label lblMaKhoa;
            this.pnlKhoa = new DevExpress.XtraEditors.PanelControl();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.dS = new QLDSV_TC.DS();
            this.barChucNangLop = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThemLop = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaLop = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaLop = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhiLop = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoiLop = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.taLop = new QLDSV_TC.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV_TC.DSTableAdapters.TableAdapterManager();
            this.taSinhVienLop = new QLDSV_TC.DSTableAdapters.SINHVIENTableAdapter();
            this.gcLop = new DevExpress.XtraGrid.GridControl();
            this.gvLop = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKHOAHOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gbThongTinLop = new System.Windows.Forms.GroupBox();
            this.teMaLop = new DevExpress.XtraEditors.TextEdit();
            this.teTenLop = new DevExpress.XtraEditors.TextEdit();
            this.teKhoaHoc = new DevExpress.XtraEditors.TextEdit();
            this.teMaKhoa = new DevExpress.XtraEditors.TextEdit();
            this.bdsSinhVienLop = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ghiVàoCSDLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phụcHồiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bdsDangKy = new System.Windows.Forms.BindingSource(this.components);
            this.taDangKy = new QLDSV_TC.DSTableAdapters.DANGKYTableAdapter();
            this.gcSinhVienLop = new DevExpress.XtraGrid.GridControl();
            this.gvSinhVienLop = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDANGHIHOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPASSWORD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsKhoa = new System.Windows.Forms.BindingSource(this.components);
            this.taKhoa = new QLDSV_TC.DSTableAdapters.KHOATableAdapter();
            lblMaLop = new System.Windows.Forms.Label();
            lblTenLop = new System.Windows.Forms.Label();
            lblKhoaHoc = new System.Windows.Forms.Label();
            lblMaKhoa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pnlKhoa)).BeginInit();
            this.pnlKhoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barChucNangLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLop)).BeginInit();
            this.gbThongTinLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTenLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teKhoaHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMaKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVienLop)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDangKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSinhVienLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSinhVienLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaLop
            // 
            lblMaLop.AutoSize = true;
            lblMaLop.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblMaLop.Location = new System.Drawing.Point(24, 100);
            lblMaLop.Name = "lblMaLop";
            lblMaLop.Size = new System.Drawing.Size(72, 23);
            lblMaLop.TabIndex = 0;
            lblMaLop.Text = "Mã lớp";
            // 
            // lblTenLop
            // 
            lblTenLop.AutoSize = true;
            lblTenLop.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTenLop.Location = new System.Drawing.Point(24, 129);
            lblTenLop.Name = "lblTenLop";
            lblTenLop.Size = new System.Drawing.Size(77, 23);
            lblTenLop.TabIndex = 2;
            lblTenLop.Text = "Tên lớp";
            // 
            // lblKhoaHoc
            // 
            lblKhoaHoc.AutoSize = true;
            lblKhoaHoc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblKhoaHoc.Location = new System.Drawing.Point(24, 158);
            lblKhoaHoc.Name = "lblKhoaHoc";
            lblKhoaHoc.Size = new System.Drawing.Size(92, 23);
            lblKhoaHoc.TabIndex = 4;
            lblKhoaHoc.Text = "Khóa học";
            // 
            // lblMaKhoa
            // 
            lblMaKhoa.AutoSize = true;
            lblMaKhoa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblMaKhoa.Location = new System.Drawing.Point(24, 187);
            lblMaKhoa.Name = "lblMaKhoa";
            lblMaKhoa.Size = new System.Drawing.Size(86, 23);
            lblMaKhoa.TabIndex = 6;
            lblMaKhoa.Text = "Mã khoa";
            // 
            // pnlKhoa
            // 
            this.pnlKhoa.Controls.Add(this.cmbKhoa);
            this.pnlKhoa.Controls.Add(this.lblKhoa);
            this.pnlKhoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKhoa.Enabled = false;
            this.pnlKhoa.Location = new System.Drawing.Point(0, 25);
            this.pnlKhoa.Name = "pnlKhoa";
            this.pnlKhoa.Size = new System.Drawing.Size(1447, 55);
            this.pnlKhoa.TabIndex = 0;
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DisplayMember = "TENCN";
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(234, 12);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(445, 31);
            this.cmbKhoa.TabIndex = 1;
            this.cmbKhoa.ValueMember = "TENSERVER";
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhoa.Location = new System.Drawing.Point(142, 15);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(65, 23);
            this.lblKhoa.TabIndex = 0;
            this.lblKhoa.Text = "KHOA";
            this.lblKhoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.EnforceConstraints = false;
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barChucNangLop
            // 
            this.barChucNangLop.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barChucNangLop.DockControls.Add(this.barDockControlTop);
            this.barChucNangLop.DockControls.Add(this.barDockControlBottom);
            this.barChucNangLop.DockControls.Add(this.barDockControlLeft);
            this.barChucNangLop.DockControls.Add(this.barDockControlRight);
            this.barChucNangLop.DockWindowTabFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barChucNangLop.Form = this;
            this.barChucNangLop.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThemLop,
            this.btnXoaLop,
            this.btnSuaLop,
            this.btnGhiLop,
            this.btnPhucHoiLop,
            this.btnThoat,
            this.btnHuy});
            this.barChucNangLop.MainMenu = this.bar2;
            this.barChucNangLop.MaxItemId = 7;
            this.barChucNangLop.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThemLop),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoaLop),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSuaLop),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHuy),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGhiLop),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPhucHoiLop),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThemLop
            // 
            this.btnThemLop.Caption = "Thêm";
            this.btnThemLop.Id = 0;
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemLop_ItemClick);
            // 
            // btnXoaLop
            // 
            this.btnXoaLop.Caption = "Xóa";
            this.btnXoaLop.Id = 1;
            this.btnXoaLop.Name = "btnXoaLop";
            this.btnXoaLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaLop_ItemClick);
            // 
            // btnSuaLop
            // 
            this.btnSuaLop.Caption = "Sửa";
            this.btnSuaLop.Id = 2;
            this.btnSuaLop.Name = "btnSuaLop";
            this.btnSuaLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSuaLop_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Enabled = false;
            this.btnHuy.Id = 6;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnGhiLop
            // 
            this.btnGhiLop.Caption = "Ghi";
            this.btnGhiLop.Enabled = false;
            this.btnGhiLop.Id = 3;
            this.btnGhiLop.Name = "btnGhiLop";
            this.btnGhiLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhiLop_ItemClick);
            // 
            // btnPhucHoiLop
            // 
            this.btnPhucHoiLop.Caption = "Phục hồi";
            this.btnPhucHoiLop.Enabled = false;
            this.btnPhucHoiLop.Id = 4;
            this.btnPhucHoiLop.Name = "btnPhucHoiLop";
            this.btnPhucHoiLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoiLop_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 5;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barChucNangLop;
            this.barDockControlTop.Size = new System.Drawing.Size(1447, 25);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 635);
            this.barDockControlBottom.Manager = this.barChucNangLop;
            this.barDockControlBottom.Size = new System.Drawing.Size(1447, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 25);
            this.barDockControlLeft.Manager = this.barChucNangLop;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 610);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1447, 25);
            this.barDockControlRight.Manager = this.barChucNangLop;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 610);
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "LOP";
            this.bdsLop.DataSource = this.dS;
            // 
            // taLop
            // 
            this.taLop.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_DONGHOCPHITableAdapter = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENINFOTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.taLop;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.taSinhVienLop;
            this.tableAdapterManager.UpdateOrder = QLDSV_TC.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // taSinhVienLop
            // 
            this.taSinhVienLop.ClearBeforeFill = true;
            // 
            // gcLop
            // 
            this.gcLop.DataSource = this.bdsLop;
            this.gcLop.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcLop.Location = new System.Drawing.Point(0, 80);
            this.gcLop.MainView = this.gvLop;
            this.gcLop.MenuManager = this.barChucNangLop;
            this.gcLop.Name = "gcLop";
            this.gcLop.Size = new System.Drawing.Size(1447, 265);
            this.gcLop.TabIndex = 5;
            this.gcLop.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLop});
            // 
            // gvLop
            // 
            this.gvLop.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP,
            this.colTENLOP,
            this.colKHOAHOC,
            this.colMAKHOA});
            this.gvLop.GridControl = this.gcLop;
            this.gvLop.Name = "gvLop";
            this.gvLop.OptionsBehavior.ReadOnly = true;
            this.gvLop.OptionsDetail.EnableMasterViewMode = false;
            this.gvLop.OptionsView.ShowGroupPanel = false;
            this.gvLop.OptionsView.ShowViewCaption = true;
            this.gvLop.ViewCaption = "DANH SÁCH LỚP";
            this.gvLop.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gvLop_SelectionChanged);
            // 
            // colMALOP
            // 
            this.colMALOP.Caption = "Mã lớp";
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.MinWidth = 25;
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 0;
            this.colMALOP.Width = 94;
            // 
            // colTENLOP
            // 
            this.colTENLOP.Caption = "Tên lớp";
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.MinWidth = 25;
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 1;
            this.colTENLOP.Width = 94;
            // 
            // colKHOAHOC
            // 
            this.colKHOAHOC.Caption = "Khóa học";
            this.colKHOAHOC.FieldName = "KHOAHOC";
            this.colKHOAHOC.MinWidth = 25;
            this.colKHOAHOC.Name = "colKHOAHOC";
            this.colKHOAHOC.Visible = true;
            this.colKHOAHOC.VisibleIndex = 2;
            this.colKHOAHOC.Width = 94;
            // 
            // colMAKHOA
            // 
            this.colMAKHOA.Caption = "Mã khoa";
            this.colMAKHOA.FieldName = "MAKHOA";
            this.colMAKHOA.MinWidth = 25;
            this.colMAKHOA.Name = "colMAKHOA";
            this.colMAKHOA.Visible = true;
            this.colMAKHOA.VisibleIndex = 3;
            this.colMAKHOA.Width = 94;
            // 
            // gbThongTinLop
            // 
            this.gbThongTinLop.Controls.Add(lblMaLop);
            this.gbThongTinLop.Controls.Add(this.teMaLop);
            this.gbThongTinLop.Controls.Add(lblTenLop);
            this.gbThongTinLop.Controls.Add(this.teTenLop);
            this.gbThongTinLop.Controls.Add(lblKhoaHoc);
            this.gbThongTinLop.Controls.Add(this.teKhoaHoc);
            this.gbThongTinLop.Controls.Add(lblMaKhoa);
            this.gbThongTinLop.Controls.Add(this.teMaKhoa);
            this.gbThongTinLop.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbThongTinLop.Enabled = false;
            this.gbThongTinLop.Location = new System.Drawing.Point(0, 345);
            this.gbThongTinLop.Name = "gbThongTinLop";
            this.gbThongTinLop.Size = new System.Drawing.Size(510, 290);
            this.gbThongTinLop.TabIndex = 6;
            this.gbThongTinLop.TabStop = false;
            this.gbThongTinLop.Text = "THÔNG TIN LỚP";
            // 
            // teMaLop
            // 
            this.teMaLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "MALOP", true));
            this.teMaLop.Location = new System.Drawing.Point(144, 97);
            this.teMaLop.MenuManager = this.barChucNangLop;
            this.teMaLop.Name = "teMaLop";
            this.teMaLop.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teMaLop.Properties.Appearance.Options.UseFont = true;
            this.teMaLop.Properties.MaxLength = 10;
            this.teMaLop.Size = new System.Drawing.Size(332, 30);
            this.teMaLop.TabIndex = 1;
            // 
            // teTenLop
            // 
            this.teTenLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "TENLOP", true));
            this.teTenLop.Location = new System.Drawing.Point(144, 126);
            this.teTenLop.MenuManager = this.barChucNangLop;
            this.teTenLop.Name = "teTenLop";
            this.teTenLop.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teTenLop.Properties.Appearance.Options.UseFont = true;
            this.teTenLop.Properties.MaxLength = 50;
            this.teTenLop.Size = new System.Drawing.Size(332, 30);
            this.teTenLop.TabIndex = 3;
            // 
            // teKhoaHoc
            // 
            this.teKhoaHoc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "KHOAHOC", true));
            this.teKhoaHoc.Location = new System.Drawing.Point(144, 155);
            this.teKhoaHoc.MenuManager = this.barChucNangLop;
            this.teKhoaHoc.Name = "teKhoaHoc";
            this.teKhoaHoc.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teKhoaHoc.Properties.Appearance.Options.UseFont = true;
            this.teKhoaHoc.Properties.MaxLength = 9;
            this.teKhoaHoc.Size = new System.Drawing.Size(332, 30);
            this.teKhoaHoc.TabIndex = 5;
            // 
            // teMaKhoa
            // 
            this.teMaKhoa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "MAKHOA", true));
            this.teMaKhoa.Enabled = false;
            this.teMaKhoa.Location = new System.Drawing.Point(144, 184);
            this.teMaKhoa.MenuManager = this.barChucNangLop;
            this.teMaKhoa.Name = "teMaKhoa";
            this.teMaKhoa.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teMaKhoa.Properties.Appearance.Options.UseFont = true;
            this.teMaKhoa.Properties.MaxLength = 10;
            this.teMaKhoa.Size = new System.Drawing.Size(332, 30);
            this.teMaKhoa.TabIndex = 7;
            // 
            // bdsSinhVienLop
            // 
            this.bdsSinhVienLop.DataMember = "FK_SINHVIEN_LOP";
            this.bdsSinhVienLop.DataSource = this.bdsLop;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmSinhViênToolStripMenuItem,
            this.xóaSinhViênToolStripMenuItem,
            this.sửaSinhViênToolStripMenuItem,
            this.ghiVàoCSDLToolStripMenuItem,
            this.phụcHồiToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(177, 124);
            // 
            // thêmSinhViênToolStripMenuItem
            // 
            this.thêmSinhViênToolStripMenuItem.Name = "thêmSinhViênToolStripMenuItem";
            this.thêmSinhViênToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.thêmSinhViênToolStripMenuItem.Text = "Thêm sinh viên";
            this.thêmSinhViênToolStripMenuItem.Click += new System.EventHandler(this.thêmSinhViênToolStripMenuItem_Click);
            // 
            // xóaSinhViênToolStripMenuItem
            // 
            this.xóaSinhViênToolStripMenuItem.Name = "xóaSinhViênToolStripMenuItem";
            this.xóaSinhViênToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.xóaSinhViênToolStripMenuItem.Text = "Xóa sinh viên";
            this.xóaSinhViênToolStripMenuItem.Click += new System.EventHandler(this.xóaSinhViênToolStripMenuItem_Click);
            // 
            // sửaSinhViênToolStripMenuItem
            // 
            this.sửaSinhViênToolStripMenuItem.Name = "sửaSinhViênToolStripMenuItem";
            this.sửaSinhViênToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.sửaSinhViênToolStripMenuItem.Text = "Sửa sinh viên";
            this.sửaSinhViênToolStripMenuItem.Click += new System.EventHandler(this.sửaSinhViênToolStripMenuItem_Click);
            // 
            // ghiVàoCSDLToolStripMenuItem
            // 
            this.ghiVàoCSDLToolStripMenuItem.Name = "ghiVàoCSDLToolStripMenuItem";
            this.ghiVàoCSDLToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.ghiVàoCSDLToolStripMenuItem.Text = "Ghi vào CSDL";
            this.ghiVàoCSDLToolStripMenuItem.Click += new System.EventHandler(this.ghiVàoCSDLToolStripMenuItem_Click);
            // 
            // phụcHồiToolStripMenuItem
            // 
            this.phụcHồiToolStripMenuItem.Name = "phụcHồiToolStripMenuItem";
            this.phụcHồiToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.phụcHồiToolStripMenuItem.Text = "Phục hồi";
            // 
            // bdsDangKy
            // 
            this.bdsDangKy.DataMember = "FK_CTLTC_SINHVIEN";
            this.bdsDangKy.DataSource = this.bdsSinhVienLop;
            // 
            // taDangKy
            // 
            this.taDangKy.ClearBeforeFill = true;
            // 
            // gcSinhVienLop
            // 
            this.gcSinhVienLop.ContextMenuStrip = this.contextMenuStrip1;
            this.gcSinhVienLop.DataSource = this.bdsSinhVienLop;
            this.gcSinhVienLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSinhVienLop.Location = new System.Drawing.Point(510, 345);
            this.gcSinhVienLop.MainView = this.gvSinhVienLop;
            this.gcSinhVienLop.MenuManager = this.barChucNangLop;
            this.gcSinhVienLop.Name = "gcSinhVienLop";
            this.gcSinhVienLop.Size = new System.Drawing.Size(937, 290);
            this.gcSinhVienLop.TabIndex = 16;
            this.gcSinhVienLop.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSinhVienLop});
            // 
            // gvSinhVienLop
            // 
            this.gvSinhVienLop.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHO,
            this.colTEN,
            this.colPHAI,
            this.colDIACHI,
            this.colNGAYSINH,
            this.colMALOP1,
            this.colDANGHIHOC,
            this.colPASSWORD});
            this.gvSinhVienLop.GridControl = this.gcSinhVienLop;
            this.gvSinhVienLop.Name = "gvSinhVienLop";
            this.gvSinhVienLop.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvSinhVienLop.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvSinhVienLop.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.gvSinhVienLop.OptionsDetail.EnableMasterViewMode = false;
            this.gvSinhVienLop.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.False;
            this.gvSinhVienLop.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.False;
            this.gvSinhVienLop.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.False;
            this.gvSinhVienLop.OptionsView.ShowGroupPanel = false;
            this.gvSinhVienLop.OptionsView.ShowViewCaption = true;
            this.gvSinhVienLop.ViewCaption = "DANH SÁCH SINH VIÊN";
            this.gvSinhVienLop.EditFormShowing += new DevExpress.XtraGrid.Views.Grid.EditFormShowingEventHandler(this.gvSinhVienLop_EditFormShowing);
            this.gvSinhVienLop.EditFormPrepared += new DevExpress.XtraGrid.Views.Grid.EditFormPreparedEventHandler(this.gvSinhVienLop_PreparedEditForm);
            this.gvSinhVienLop.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvSinhVienLop_InitNewRow);
            this.gvSinhVienLop.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gvSinhVienLop_InvalidRowException);
            this.gvSinhVienLop.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvSinhVienLop_ValidateRow);
            // 
            // colMASV
            // 
            this.colMASV.Caption = "Mã sinh viên";
            this.colMASV.FieldName = "MASV";
            this.colMASV.MinWidth = 25;
            this.colMASV.Name = "colMASV";
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            this.colMASV.Width = 94;
            // 
            // colHO
            // 
            this.colHO.Caption = "Họ";
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 25;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 94;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 25;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 94;
            // 
            // colPHAI
            // 
            this.colPHAI.Caption = "Phái";
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.MinWidth = 25;
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 3;
            this.colPHAI.Width = 94;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "Địa chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 25;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 4;
            this.colDIACHI.Width = 94;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.Caption = "Ngày sinh";
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.MinWidth = 25;
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 5;
            this.colNGAYSINH.Width = 94;
            // 
            // colMALOP1
            // 
            this.colMALOP1.Caption = "Mã lớp";
            this.colMALOP1.FieldName = "MALOP";
            this.colMALOP1.MinWidth = 25;
            this.colMALOP1.Name = "colMALOP1";
            this.colMALOP1.Visible = true;
            this.colMALOP1.VisibleIndex = 6;
            this.colMALOP1.Width = 94;
            // 
            // colDANGHIHOC
            // 
            this.colDANGHIHOC.Caption = "Đã nghỉ học";
            this.colDANGHIHOC.FieldName = "DANGHIHOC";
            this.colDANGHIHOC.MinWidth = 25;
            this.colDANGHIHOC.Name = "colDANGHIHOC";
            this.colDANGHIHOC.Visible = true;
            this.colDANGHIHOC.VisibleIndex = 7;
            this.colDANGHIHOC.Width = 94;
            // 
            // colPASSWORD
            // 
            this.colPASSWORD.Caption = "Mật khẩu";
            this.colPASSWORD.FieldName = "PASSWORD";
            this.colPASSWORD.MinWidth = 25;
            this.colPASSWORD.Name = "colPASSWORD";
            this.colPASSWORD.Visible = true;
            this.colPASSWORD.VisibleIndex = 8;
            this.colPASSWORD.Width = 94;
            // 
            // bdsKhoa
            // 
            this.bdsKhoa.DataMember = "KHOA";
            this.bdsKhoa.DataSource = this.dS;
            // 
            // taKhoa
            // 
            this.taKhoa.ClearBeforeFill = true;
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 655);
            this.Controls.Add(this.gcSinhVienLop);
            this.Controls.Add(this.gbThongTinLop);
            this.Controls.Add(this.gcLop);
            this.Controls.Add(this.pnlKhoa);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSinhVien";
            this.Text = "SINH VIÊN";
            this.Load += new System.EventHandler(this.frmSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlKhoa)).EndInit();
            this.pnlKhoa.ResumeLayout(false);
            this.pnlKhoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barChucNangLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLop)).EndInit();
            this.gbThongTinLop.ResumeLayout(false);
            this.gbThongTinLop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTenLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teKhoaHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMaKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVienLop)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsDangKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSinhVienLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSinhVienLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlKhoa;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label lblKhoa;
        private DS dS;
        private DevExpress.XtraBars.BarManager barChucNangLop;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThemLop;
        private DevExpress.XtraBars.BarButtonItem btnXoaLop;
        private DevExpress.XtraBars.BarButtonItem btnSuaLop;
        private DevExpress.XtraBars.BarButtonItem btnGhiLop;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoiLop;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsLop;
        private DSTableAdapters.LOPTableAdapter taLop;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcLop;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLop;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colKHOAHOC;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHOA;
        private System.Windows.Forms.GroupBox gbThongTinLop;
        private DSTableAdapters.SINHVIENTableAdapter taSinhVienLop;
        private System.Windows.Forms.BindingSource bdsSinhVienLop;
        private DevExpress.XtraEditors.TextEdit teMaLop;
        private DevExpress.XtraEditors.TextEdit teTenLop;
        private DevExpress.XtraEditors.TextEdit teKhoaHoc;
        private DevExpress.XtraEditors.TextEdit teMaKhoa;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thêmSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ghiVàoCSDLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phụcHồiToolStripMenuItem;
        private System.Windows.Forms.BindingSource bdsDangKy;
        private DSTableAdapters.DANGKYTableAdapter taDangKy;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraGrid.GridControl gcSinhVienLop;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSinhVienLop;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP1;
        private DevExpress.XtraGrid.Columns.GridColumn colDANGHIHOC;
        private DevExpress.XtraGrid.Columns.GridColumn colPASSWORD;
        private System.Windows.Forms.ToolStripMenuItem sửaSinhViênToolStripMenuItem;
        private System.Windows.Forms.BindingSource bdsKhoa;
        private DSTableAdapters.KHOATableAdapter taKhoa;
    }
}