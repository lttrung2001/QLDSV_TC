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
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label kHOAHOCLabel;
            System.Windows.Forms.Label mAKHOALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSinhVien));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.barChucNang = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnInDanhSach = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barLargeButtonItem1 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.dS = new QLDSV_TC.DS();
            this.bdsDSPhanManh = new System.Windows.Forms.BindingSource(this.components);
            this.taDSPhanManh = new QLDSV_TC.DSTableAdapters.V_DS_PHANMANHTableAdapter();
            this.colKHOAHOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.tableAdapterManager = new QLDSV_TC.DSTableAdapters.TableAdapterManager();
            this.taLop = new QLDSV_TC.DSTableAdapters.LOPTableAdapter();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.dSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colKHOAHOC1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lOPGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKHOAHOC2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gbThongTinLop = new System.Windows.Forms.GroupBox();
            this.mALOPTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tENLOPTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.kHOAHOCTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mAKHOATextEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.bdsSinhVien = new System.Windows.Forms.BindingSource(this.components);
            this.taSinhVien = new QLDSV_TC.DSTableAdapters.SINHVIENTableAdapter();
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gcSinhVienThuocLop = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDANGHIHOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPASSWORD = new DevExpress.XtraGrid.Columns.GridColumn();
            mALOPLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            kHOAHOCLabel = new System.Windows.Forms.Label();
            mAKHOALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSPhanManh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.gbThongTinLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mALOPTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENLOPTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOAHOCTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAKHOATextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSinhVienThuocLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mALOPLabel.Location = new System.Drawing.Point(34, 106);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(75, 24);
            mALOPLabel.TabIndex = 0;
            mALOPLabel.Text = "Mã lớp";
            mALOPLabel.Click += new System.EventHandler(this.mALOPLabel_Click);
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENLOPLabel.Location = new System.Drawing.Point(34, 153);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(83, 24);
            tENLOPLabel.TabIndex = 2;
            tENLOPLabel.Text = "Tên lớp";
            tENLOPLabel.Click += new System.EventHandler(this.tENLOPLabel_Click);
            // 
            // kHOAHOCLabel
            // 
            kHOAHOCLabel.AutoSize = true;
            kHOAHOCLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            kHOAHOCLabel.Location = new System.Drawing.Point(34, 200);
            kHOAHOCLabel.Name = "kHOAHOCLabel";
            kHOAHOCLabel.Size = new System.Drawing.Size(100, 24);
            kHOAHOCLabel.TabIndex = 4;
            kHOAHOCLabel.Text = "Khóa học";
            kHOAHOCLabel.Click += new System.EventHandler(this.kHOAHOCLabel_Click);
            // 
            // mAKHOALabel
            // 
            mAKHOALabel.AutoSize = true;
            mAKHOALabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAKHOALabel.Location = new System.Drawing.Point(34, 247);
            mAKHOALabel.Name = "mAKHOALabel";
            mAKHOALabel.Size = new System.Drawing.Size(59, 24);
            mAKHOALabel.TabIndex = 6;
            mAKHOALabel.Text = "Khoa";
            mAKHOALabel.Click += new System.EventHandler(this.mAKHOALabel_Click);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 30);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1293, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 730);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1293, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 700);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1293, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 700);
            // 
            // barManager2
            // 
            this.barManager2.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barChucNang});
            this.barManager2.DockControls.Add(this.barDockControl1);
            this.barManager2.DockControls.Add(this.barDockControl2);
            this.barManager2.DockControls.Add(this.barDockControl3);
            this.barManager2.DockControls.Add(this.barDockControl4);
            this.barManager2.Form = this;
            this.barManager2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barEditItem1,
            this.btnThem,
            this.btnXoa,
            this.btnSua,
            this.btnGhi,
            this.btnPhucHoi,
            this.btnLamMoi,
            this.btnInDanhSach,
            this.btnThoat,
            this.barLargeButtonItem1});
            this.barManager2.MaxItemId = 10;
            this.barManager2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            // 
            // barChucNang
            // 
            this.barChucNang.BarName = "Tools";
            this.barChucNang.DockCol = 0;
            this.barChucNang.DockRow = 0;
            this.barChucNang.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barChucNang.FloatLocation = new System.Drawing.Point(67, 183);
            this.barChucNang.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLamMoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnInDanhSach, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.barChucNang.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 1;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Chỉnh sửa";
            this.btnSua.Id = 3;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 4;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 5;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.LargeImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Caption = "Làm mới";
            this.btnLamMoi.Id = 6;
            this.btnLamMoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.ImageOptions.Image")));
            this.btnLamMoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.ImageOptions.LargeImage")));
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLamMoi_ItemClick);
            // 
            // btnInDanhSach
            // 
            this.btnInDanhSach.Caption = "In danh sách sinh viên";
            this.btnInDanhSach.Id = 7;
            this.btnInDanhSach.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInDanhSach.ImageOptions.Image")));
            this.btnInDanhSach.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnInDanhSach.ImageOptions.LargeImage")));
            this.btnInDanhSach.Name = "btnInDanhSach";
            this.btnInDanhSach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInDanhSach_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 8;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControl1
            // 
            this.barDockControl1.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barDockControl1.Appearance.Options.UseFont = true;
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager2;
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControl1.Size = new System.Drawing.Size(1293, 30);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 730);
            this.barDockControl2.Manager = this.barManager2;
            this.barDockControl2.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControl2.Size = new System.Drawing.Size(1293, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 30);
            this.barDockControl3.Manager = this.barManager2;
            this.barDockControl3.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControl3.Size = new System.Drawing.Size(0, 700);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1293, 30);
            this.barDockControl4.Manager = this.barManager2;
            this.barDockControl4.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControl4.Size = new System.Drawing.Size(0, 700);
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemTextEdit1;
            this.barEditItem1.Id = 0;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // barLargeButtonItem1
            // 
            this.barLargeButtonItem1.Caption = "barLargeButtonItem1";
            this.barLargeButtonItem1.Id = 9;
            this.barLargeButtonItem1.Name = "barLargeButtonItem1";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDSPhanManh
            // 
            this.bdsDSPhanManh.DataMember = "V_DS_PHANMANH";
            this.bdsDSPhanManh.DataSource = this.dS;
            // 
            // taDSPhanManh
            // 
            this.taDSPhanManh.ClearBeforeFill = true;
            // 
            // colKHOAHOC
            // 
            this.colKHOAHOC.FieldName = "KHOAHOC";
            this.colKHOAHOC.MinWidth = 25;
            this.colKHOAHOC.Name = "colKHOAHOC";
            this.colKHOAHOC.Visible = true;
            this.colKHOAHOC.VisibleIndex = 0;
            this.colKHOAHOC.Width = 94;
            // 
            // colTENLOP
            // 
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.MinWidth = 25;
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 0;
            this.colTENLOP.Width = 94;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_DONGHOCPHITableAdapter = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.taLop;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_TC.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // taLop
            // 
            this.taLop.ClearBeforeFill = true;
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "LOP";
            this.bdsLop.DataSource = this.dS;
            // 
            // dSBindingSource
            // 
            this.dSBindingSource.DataSource = this.dS;
            this.dSBindingSource.Position = 0;
            // 
            // colKHOAHOC1
            // 
            this.colKHOAHOC1.Caption = "Khóa học";
            this.colKHOAHOC1.FieldName = "KHOAHOC";
            this.colKHOAHOC1.MinWidth = 25;
            this.colKHOAHOC1.Name = "colKHOAHOC1";
            this.colKHOAHOC1.Visible = true;
            this.colKHOAHOC1.VisibleIndex = 2;
            this.colKHOAHOC1.Width = 94;
            // 
            // colTENLOP1
            // 
            this.colTENLOP1.Caption = "Tên lớp";
            this.colTENLOP1.FieldName = "TENLOP";
            this.colTENLOP1.MinWidth = 25;
            this.colTENLOP1.Name = "colTENLOP1";
            this.colTENLOP1.Visible = true;
            this.colTENLOP1.VisibleIndex = 1;
            this.colTENLOP1.Width = 94;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Name = "gridColumn2";
            // 
            // lOPGridControl
            // 
            this.lOPGridControl.DataSource = this.bdsLop;
            this.lOPGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.lOPGridControl.Location = new System.Drawing.Point(0, 30);
            this.lOPGridControl.MainView = this.gridView1;
            this.lOPGridControl.MenuManager = this.barManager1;
            this.lOPGridControl.Name = "lOPGridControl";
            this.lOPGridControl.Size = new System.Drawing.Size(1293, 256);
            this.lOPGridControl.TabIndex = 68;
            this.lOPGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP,
            this.colTENLOP2,
            this.colKHOAHOC2,
            this.colMAKHOA});
            this.gridView1.GridControl = this.lOPGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMALOP
            // 
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.MinWidth = 25;
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.OptionsColumn.ReadOnly = true;
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 0;
            this.colMALOP.Width = 94;
            // 
            // colTENLOP2
            // 
            this.colTENLOP2.FieldName = "TENLOP";
            this.colTENLOP2.MinWidth = 25;
            this.colTENLOP2.Name = "colTENLOP2";
            this.colTENLOP2.OptionsColumn.ReadOnly = true;
            this.colTENLOP2.Visible = true;
            this.colTENLOP2.VisibleIndex = 1;
            this.colTENLOP2.Width = 94;
            // 
            // colKHOAHOC2
            // 
            this.colKHOAHOC2.FieldName = "KHOAHOC";
            this.colKHOAHOC2.MinWidth = 25;
            this.colKHOAHOC2.Name = "colKHOAHOC2";
            this.colKHOAHOC2.OptionsColumn.ReadOnly = true;
            this.colKHOAHOC2.Visible = true;
            this.colKHOAHOC2.VisibleIndex = 2;
            this.colKHOAHOC2.Width = 94;
            // 
            // colMAKHOA
            // 
            this.colMAKHOA.FieldName = "MAKHOA";
            this.colMAKHOA.MinWidth = 25;
            this.colMAKHOA.Name = "colMAKHOA";
            this.colMAKHOA.OptionsColumn.ReadOnly = true;
            this.colMAKHOA.Visible = true;
            this.colMAKHOA.VisibleIndex = 3;
            this.colMAKHOA.Width = 94;
            // 
            // gbThongTinLop
            // 
            this.gbThongTinLop.Controls.Add(mALOPLabel);
            this.gbThongTinLop.Controls.Add(this.mALOPTextEdit);
            this.gbThongTinLop.Controls.Add(tENLOPLabel);
            this.gbThongTinLop.Controls.Add(this.tENLOPTextEdit);
            this.gbThongTinLop.Controls.Add(kHOAHOCLabel);
            this.gbThongTinLop.Controls.Add(this.kHOAHOCTextEdit);
            this.gbThongTinLop.Controls.Add(mAKHOALabel);
            this.gbThongTinLop.Controls.Add(this.mAKHOATextEdit);
            this.gbThongTinLop.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbThongTinLop.Enabled = false;
            this.gbThongTinLop.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongTinLop.Location = new System.Drawing.Point(0, 286);
            this.gbThongTinLop.Name = "gbThongTinLop";
            this.gbThongTinLop.Size = new System.Drawing.Size(543, 444);
            this.gbThongTinLop.TabIndex = 69;
            this.gbThongTinLop.TabStop = false;
            this.gbThongTinLop.Text = "THÔNG TIN LỚP";
            // 
            // mALOPTextEdit
            // 
            this.mALOPTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "MALOP", true));
            this.mALOPTextEdit.Location = new System.Drawing.Point(154, 103);
            this.mALOPTextEdit.MenuManager = this.barManager1;
            this.mALOPTextEdit.Name = "mALOPTextEdit";
            this.mALOPTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mALOPTextEdit.Properties.Appearance.Options.UseFont = true;
            this.mALOPTextEdit.Size = new System.Drawing.Size(338, 30);
            this.mALOPTextEdit.TabIndex = 1;
            // 
            // tENLOPTextEdit
            // 
            this.tENLOPTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "TENLOP", true));
            this.tENLOPTextEdit.Location = new System.Drawing.Point(154, 150);
            this.tENLOPTextEdit.MenuManager = this.barManager1;
            this.tENLOPTextEdit.Name = "tENLOPTextEdit";
            this.tENLOPTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tENLOPTextEdit.Properties.Appearance.Options.UseFont = true;
            this.tENLOPTextEdit.Size = new System.Drawing.Size(338, 30);
            this.tENLOPTextEdit.TabIndex = 3;
            // 
            // kHOAHOCTextEdit
            // 
            this.kHOAHOCTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "KHOAHOC", true));
            this.kHOAHOCTextEdit.Location = new System.Drawing.Point(154, 197);
            this.kHOAHOCTextEdit.MenuManager = this.barManager1;
            this.kHOAHOCTextEdit.Name = "kHOAHOCTextEdit";
            this.kHOAHOCTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kHOAHOCTextEdit.Properties.Appearance.Options.UseFont = true;
            this.kHOAHOCTextEdit.Size = new System.Drawing.Size(338, 30);
            this.kHOAHOCTextEdit.TabIndex = 5;
            // 
            // mAKHOATextEdit
            // 
            this.mAKHOATextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "MAKHOA", true));
            this.mAKHOATextEdit.Location = new System.Drawing.Point(154, 244);
            this.mAKHOATextEdit.MenuManager = this.barManager1;
            this.mAKHOATextEdit.Name = "mAKHOATextEdit";
            this.mAKHOATextEdit.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mAKHOATextEdit.Properties.Appearance.Options.UseFont = true;
            this.mAKHOATextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.mAKHOATextEdit.Size = new System.Drawing.Size(338, 30);
            this.mAKHOATextEdit.TabIndex = 7;
            // 
            // bdsSinhVien
            // 
            this.bdsSinhVien.DataMember = "SINHVIEN";
            this.bdsSinhVien.DataSource = this.dS;
            // 
            // taSinhVien
            // 
            this.taSinhVien.ClearBeforeFill = true;
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "FK_SINHVIEN_LOP";
            this.sINHVIENBindingSource.DataSource = this.bdsLop;
            // 
            // gcSinhVienThuocLop
            // 
            this.gcSinhVienThuocLop.DataSource = this.sINHVIENBindingSource;
            this.gcSinhVienThuocLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSinhVienThuocLop.Location = new System.Drawing.Point(543, 286);
            this.gcSinhVienThuocLop.MainView = this.gridView2;
            this.gcSinhVienThuocLop.MenuManager = this.barManager1;
            this.gcSinhVienThuocLop.Name = "gcSinhVienThuocLop";
            this.gcSinhVienThuocLop.Size = new System.Drawing.Size(750, 444);
            this.gcSinhVienThuocLop.TabIndex = 77;
            this.gcSinhVienThuocLop.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHO,
            this.colTEN,
            this.colPHAI,
            this.colDIACHI,
            this.colNGAYSINH,
            this.colMALOP1,
            this.colDANGHIHOC,
            this.colPASSWORD});
            this.gridView2.GridControl = this.gcSinhVienThuocLop;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colMASV
            // 
            this.colMASV.FieldName = "MASV";
            this.colMASV.MinWidth = 25;
            this.colMASV.Name = "colMASV";
            this.colMASV.OptionsColumn.ReadOnly = true;
            this.colMASV.OptionsFilter.AllowFilter = false;
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            this.colMASV.Width = 94;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 25;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 94;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 25;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 94;
            // 
            // colPHAI
            // 
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.MinWidth = 25;
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 3;
            this.colPHAI.Width = 94;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 25;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 4;
            this.colDIACHI.Width = 94;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.MinWidth = 25;
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 5;
            this.colNGAYSINH.Width = 94;
            // 
            // colMALOP1
            // 
            this.colMALOP1.FieldName = "MALOP";
            this.colMALOP1.MinWidth = 25;
            this.colMALOP1.Name = "colMALOP1";
            this.colMALOP1.Visible = true;
            this.colMALOP1.VisibleIndex = 6;
            this.colMALOP1.Width = 94;
            // 
            // colDANGHIHOC
            // 
            this.colDANGHIHOC.FieldName = "DANGHIHOC";
            this.colDANGHIHOC.MinWidth = 25;
            this.colDANGHIHOC.Name = "colDANGHIHOC";
            this.colDANGHIHOC.Visible = true;
            this.colDANGHIHOC.VisibleIndex = 7;
            this.colDANGHIHOC.Width = 94;
            // 
            // colPASSWORD
            // 
            this.colPASSWORD.FieldName = "PASSWORD";
            this.colPASSWORD.MinWidth = 25;
            this.colPASSWORD.Name = "colPASSWORD";
            this.colPASSWORD.Visible = true;
            this.colPASSWORD.VisibleIndex = 8;
            this.colPASSWORD.Width = 94;
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 730);
            this.Controls.Add(this.gcSinhVienThuocLop);
            this.Controls.Add(this.gbThongTinLop);
            this.Controls.Add(this.lOPGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSinhVien";
            this.Text = "Sinh viên";
            this.Load += new System.EventHandler(this.frmSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSPhanManh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.gbThongTinLop.ResumeLayout(false);
            this.gbThongTinLop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mALOPTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENLOPTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOAHOCTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAKHOATextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSinhVienThuocLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.Bar barChucNang;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnLamMoi;
        private DevExpress.XtraBars.BarButtonItem btnInDanhSach;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem1;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsDSPhanManh;
        private DSTableAdapters.V_DS_PHANMANHTableAdapter taDSPhanManh;
        private DevExpress.XtraGrid.Columns.GridColumn colKHOAHOC;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource dSBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colKHOAHOC1;
        private System.Windows.Forms.BindingSource bdsLop;
        private DSTableAdapters.LOPTableAdapter taLop;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.GridControl lOPGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP2;
        private DevExpress.XtraGrid.Columns.GridColumn colKHOAHOC2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHOA;
        private System.Windows.Forms.GroupBox gbThongTinLop;
        private DevExpress.XtraEditors.TextEdit mALOPTextEdit;
        private DevExpress.XtraEditors.TextEdit tENLOPTextEdit;
        private DevExpress.XtraEditors.TextEdit kHOAHOCTextEdit;
        private DevExpress.XtraEditors.ComboBoxEdit mAKHOATextEdit;
        private System.Windows.Forms.BindingSource bdsSinhVien;
        private DSTableAdapters.SINHVIENTableAdapter taSinhVien;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private DevExpress.XtraGrid.GridControl gcSinhVienThuocLop;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP1;
        private DevExpress.XtraGrid.Columns.GridColumn colDANGHIHOC;
        private DevExpress.XtraGrid.Columns.GridColumn colPASSWORD;
    }
}