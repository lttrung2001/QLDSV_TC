namespace QLDSV_TC
{
    partial class frmDangKyMon
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
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label tENMHLabel;
            System.Windows.Forms.Label nHOMLabel;
            System.Windows.Forms.Label hOTENGVLabel;
            this.pnlThongTinSV = new System.Windows.Forms.Panel();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.teMaLop = new System.Windows.Forms.TextBox();
            this.teHoTen = new System.Windows.Forms.TextBox();
            this.teMaSV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.bdsNienKhoa = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLDSV_TC.DS();
            this.taNienKhoa = new QLDSV_TC.DSTableAdapters.NIENKHOATableAdapter();
            this.tableAdapterManager = new QLDSV_TC.DSTableAdapters.TableAdapterManager();
            this.pnlLocLopTinChi = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThoatDangKy = new System.Windows.Forms.Button();
            this.btnLoc = new System.Windows.Forms.Button();
            this.cmbHocKy = new System.Windows.Forms.ComboBox();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
            this.lblNienKhoa = new System.Windows.Forms.Label();
            this.sP_LOCLTCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_LOCLTCTableAdapter = new QLDSV_TC.DSTableAdapters.SP_LOCLTCTableAdapter();
            this.sP_LOCLTCGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTENGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSLDADANGKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHUYDANGKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sP_LAY_DSLTC_SVDKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_LAY_DSLTC_SVDKTableAdapter = new QLDSV_TC.DSTableAdapters.SP_LAY_DSLTC_SVDKTableAdapter();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.mAMHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tENMHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nHOMSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.hOTENGVTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.sP_LAY_DSLTC_SVDKGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHOM1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTENGV1 = new DevExpress.XtraGrid.Columns.GridColumn();
            mAMHLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            nHOMLabel = new System.Windows.Forms.Label();
            hOTENGVLabel = new System.Windows.Forms.Label();
            this.pnlThongTinSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNienKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            this.pnlLocLopTinChi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LOCLTCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LOCLTCGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAY_DSLTC_SVDKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mAMHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENMHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTENGVTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAY_DSLTC_SVDKGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(32, 61);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(76, 23);
            mAMHLabel.TabIndex = 0;
            mAMHLabel.Text = "MAMH:";
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(32, 90);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(84, 23);
            tENMHLabel.TabIndex = 2;
            tENMHLabel.Text = "TENMH:";
            // 
            // nHOMLabel
            // 
            nHOMLabel.AutoSize = true;
            nHOMLabel.Location = new System.Drawing.Point(32, 119);
            nHOMLabel.Name = "nHOMLabel";
            nHOMLabel.Size = new System.Drawing.Size(75, 23);
            nHOMLabel.TabIndex = 4;
            nHOMLabel.Text = "NHOM:";
            // 
            // hOTENGVLabel
            // 
            hOTENGVLabel.AutoSize = true;
            hOTENGVLabel.Location = new System.Drawing.Point(32, 149);
            hOTENGVLabel.Name = "hOTENGVLabel";
            hOTENGVLabel.Size = new System.Drawing.Size(111, 23);
            hOTENGVLabel.TabIndex = 6;
            hOTENGVLabel.Text = "HOTENGV:";
            // 
            // pnlThongTinSV
            // 
            this.pnlThongTinSV.Controls.Add(this.btnXacNhan);
            this.pnlThongTinSV.Controls.Add(this.teMaLop);
            this.pnlThongTinSV.Controls.Add(this.teHoTen);
            this.pnlThongTinSV.Controls.Add(this.teMaSV);
            this.pnlThongTinSV.Controls.Add(this.label3);
            this.pnlThongTinSV.Controls.Add(this.label2);
            this.pnlThongTinSV.Controls.Add(this.lblMaSV);
            this.pnlThongTinSV.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlThongTinSV.Location = new System.Drawing.Point(0, 0);
            this.pnlThongTinSV.Name = "pnlThongTinSV";
            this.pnlThongTinSV.Size = new System.Drawing.Size(1315, 141);
            this.pnlThongTinSV.TabIndex = 0;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(558, 18);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(128, 34);
            this.btnXacNhan.TabIndex = 11;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // teMaLop
            // 
            this.teMaLop.Location = new System.Drawing.Point(146, 91);
            this.teMaLop.Name = "teMaLop";
            this.teMaLop.ReadOnly = true;
            this.teMaLop.Size = new System.Drawing.Size(540, 30);
            this.teMaLop.TabIndex = 5;
            // 
            // teHoTen
            // 
            this.teHoTen.Location = new System.Drawing.Point(146, 56);
            this.teHoTen.Name = "teHoTen";
            this.teHoTen.ReadOnly = true;
            this.teHoTen.Size = new System.Drawing.Size(540, 30);
            this.teHoTen.TabIndex = 4;
            // 
            // teMaSV
            // 
            this.teMaSV.Location = new System.Drawing.Point(146, 21);
            this.teMaSV.Name = "teMaSV";
            this.teMaSV.Size = new System.Drawing.Size(321, 30);
            this.teMaSV.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(22, 24);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(118, 23);
            this.lblMaSV.TabIndex = 0;
            this.lblMaSV.Text = "Mã sinh viên";
            // 
            // bdsNienKhoa
            // 
            this.bdsNienKhoa.DataMember = "NIENKHOA";
            this.bdsNienKhoa.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.EnforceConstraints = false;
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taNienKhoa
            // 
            this.taNienKhoa.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CT_DONGHOCPHITableAdapter = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENINFOTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_TC.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pnlLocLopTinChi
            // 
            this.pnlLocLopTinChi.Controls.Add(this.btnThoat);
            this.pnlLocLopTinChi.Controls.Add(this.btnThoatDangKy);
            this.pnlLocLopTinChi.Controls.Add(this.btnLoc);
            this.pnlLocLopTinChi.Controls.Add(this.cmbHocKy);
            this.pnlLocLopTinChi.Controls.Add(this.lblHocKy);
            this.pnlLocLopTinChi.Controls.Add(this.cmbNienKhoa);
            this.pnlLocLopTinChi.Controls.Add(this.lblNienKhoa);
            this.pnlLocLopTinChi.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLocLopTinChi.Enabled = false;
            this.pnlLocLopTinChi.Location = new System.Drawing.Point(0, 141);
            this.pnlLocLopTinChi.Name = "pnlLocLopTinChi";
            this.pnlLocLopTinChi.Size = new System.Drawing.Size(1315, 37);
            this.pnlLocLopTinChi.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(971, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(155, 31);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát form";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThoatDangKy
            // 
            this.btnThoatDangKy.Location = new System.Drawing.Point(810, 3);
            this.btnThoatDangKy.Name = "btnThoatDangKy";
            this.btnThoatDangKy.Size = new System.Drawing.Size(155, 31);
            this.btnThoatDangKy.TabIndex = 7;
            this.btnThoatDangKy.Text = "Thoát đăng ký";
            this.btnThoatDangKy.UseVisualStyleBackColor = true;
            this.btnThoatDangKy.Click += new System.EventHandler(this.btnThoatDangKy_Click);
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(719, 3);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(85, 31);
            this.btnLoc.TabIndex = 6;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // cmbHocKy
            // 
            this.cmbHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHocKy.FormattingEnabled = true;
            this.cmbHocKy.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbHocKy.Location = new System.Drawing.Point(453, 3);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Size = new System.Drawing.Size(245, 31);
            this.cmbHocKy.TabIndex = 5;
            this.cmbHocKy.SelectedIndexChanged += new System.EventHandler(this.cmbHocKy_SelectedIndexChanged);
            // 
            // lblHocKy
            // 
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Location = new System.Drawing.Point(377, 6);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(70, 23);
            this.lblHocKy.TabIndex = 4;
            this.lblHocKy.Text = "Học kỳ";
            // 
            // cmbNienKhoa
            // 
            this.cmbNienKhoa.DataSource = this.bdsNienKhoa;
            this.cmbNienKhoa.DisplayMember = "NIENKHOA";
            this.cmbNienKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNienKhoa.FormattingEnabled = true;
            this.cmbNienKhoa.Location = new System.Drawing.Point(114, 3);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Size = new System.Drawing.Size(245, 31);
            this.cmbNienKhoa.TabIndex = 3;
            this.cmbNienKhoa.ValueMember = "NIENKHOA";
            // 
            // lblNienKhoa
            // 
            this.lblNienKhoa.AutoSize = true;
            this.lblNienKhoa.Location = new System.Drawing.Point(12, 6);
            this.lblNienKhoa.Name = "lblNienKhoa";
            this.lblNienKhoa.Size = new System.Drawing.Size(96, 23);
            this.lblNienKhoa.TabIndex = 2;
            this.lblNienKhoa.Text = "Niên khóa";
            // 
            // sP_LOCLTCBindingSource
            // 
            this.sP_LOCLTCBindingSource.DataMember = "SP_LOCLTC";
            this.sP_LOCLTCBindingSource.DataSource = this.dS;
            // 
            // sP_LOCLTCTableAdapter
            // 
            this.sP_LOCLTCTableAdapter.ClearBeforeFill = true;
            // 
            // sP_LOCLTCGridControl
            // 
            this.sP_LOCLTCGridControl.DataSource = this.sP_LOCLTCBindingSource;
            this.sP_LOCLTCGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.sP_LOCLTCGridControl.Enabled = false;
            this.sP_LOCLTCGridControl.Location = new System.Drawing.Point(0, 178);
            this.sP_LOCLTCGridControl.MainView = this.gridView1;
            this.sP_LOCLTCGridControl.Name = "sP_LOCLTCGridControl";
            this.sP_LOCLTCGridControl.Size = new System.Drawing.Size(1315, 259);
            this.sP_LOCLTCGridControl.TabIndex = 3;
            this.sP_LOCLTCGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colTENMH,
            this.colNHOM,
            this.colHOTENGV,
            this.colSLDADANGKY,
            this.colHUYDANGKY});
            this.gridView1.GridControl = this.sP_LOCLTCGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "DANH SÁCH LỚP TÍN CHỈ";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.MinWidth = 25;
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 0;
            this.colMAMH.Width = 94;
            // 
            // colTENMH
            // 
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.MinWidth = 25;
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            this.colTENMH.Width = 94;
            // 
            // colNHOM
            // 
            this.colNHOM.FieldName = "NHOM";
            this.colNHOM.MinWidth = 25;
            this.colNHOM.Name = "colNHOM";
            this.colNHOM.Visible = true;
            this.colNHOM.VisibleIndex = 2;
            this.colNHOM.Width = 94;
            // 
            // colHOTENGV
            // 
            this.colHOTENGV.FieldName = "HOTENGV";
            this.colHOTENGV.MinWidth = 25;
            this.colHOTENGV.Name = "colHOTENGV";
            this.colHOTENGV.Visible = true;
            this.colHOTENGV.VisibleIndex = 3;
            this.colHOTENGV.Width = 94;
            // 
            // colSLDADANGKY
            // 
            this.colSLDADANGKY.FieldName = "SLDADANGKY";
            this.colSLDADANGKY.MinWidth = 25;
            this.colSLDADANGKY.Name = "colSLDADANGKY";
            this.colSLDADANGKY.Visible = true;
            this.colSLDADANGKY.VisibleIndex = 4;
            this.colSLDADANGKY.Width = 94;
            // 
            // colHUYDANGKY
            // 
            this.colHUYDANGKY.FieldName = "HUYDANGKY";
            this.colHUYDANGKY.MinWidth = 25;
            this.colHUYDANGKY.Name = "colHUYDANGKY";
            this.colHUYDANGKY.Visible = true;
            this.colHUYDANGKY.VisibleIndex = 5;
            this.colHUYDANGKY.Width = 94;
            // 
            // sP_LAY_DSLTC_SVDKBindingSource
            // 
            this.sP_LAY_DSLTC_SVDKBindingSource.DataMember = "SP_LAY_DSLTC_SVDK";
            this.sP_LAY_DSLTC_SVDKBindingSource.DataSource = this.dS;
            // 
            // sP_LAY_DSLTC_SVDKTableAdapter
            // 
            this.sP_LAY_DSLTC_SVDKTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(mAMHLabel);
            this.groupBox1.Controls.Add(this.mAMHTextEdit);
            this.groupBox1.Controls.Add(tENMHLabel);
            this.groupBox1.Controls.Add(this.tENMHTextEdit);
            this.groupBox1.Controls.Add(nHOMLabel);
            this.groupBox1.Controls.Add(this.nHOMSpinEdit);
            this.groupBox1.Controls.Add(hOTENGVLabel);
            this.groupBox1.Controls.Add(this.hOTENGVTextEdit);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 437);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 237);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN LỚP TÍN CHỈ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "Đăng ký";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mAMHTextEdit
            // 
            this.mAMHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sP_LOCLTCBindingSource, "MAMH", true));
            this.mAMHTextEdit.Location = new System.Drawing.Point(149, 58);
            this.mAMHTextEdit.Name = "mAMHTextEdit";
            this.mAMHTextEdit.Properties.ReadOnly = true;
            this.mAMHTextEdit.Size = new System.Drawing.Size(227, 22);
            this.mAMHTextEdit.TabIndex = 1;
            // 
            // tENMHTextEdit
            // 
            this.tENMHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sP_LOCLTCBindingSource, "TENMH", true));
            this.tENMHTextEdit.Location = new System.Drawing.Point(149, 87);
            this.tENMHTextEdit.Name = "tENMHTextEdit";
            this.tENMHTextEdit.Properties.ReadOnly = true;
            this.tENMHTextEdit.Size = new System.Drawing.Size(227, 22);
            this.tENMHTextEdit.TabIndex = 3;
            // 
            // nHOMSpinEdit
            // 
            this.nHOMSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sP_LOCLTCBindingSource, "NHOM", true));
            this.nHOMSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nHOMSpinEdit.Location = new System.Drawing.Point(149, 116);
            this.nHOMSpinEdit.Name = "nHOMSpinEdit";
            this.nHOMSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nHOMSpinEdit.Properties.ReadOnly = true;
            this.nHOMSpinEdit.Size = new System.Drawing.Size(227, 24);
            this.nHOMSpinEdit.TabIndex = 5;
            // 
            // hOTENGVTextEdit
            // 
            this.hOTENGVTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sP_LOCLTCBindingSource, "HOTENGV", true));
            this.hOTENGVTextEdit.Location = new System.Drawing.Point(149, 146);
            this.hOTENGVTextEdit.Name = "hOTENGVTextEdit";
            this.hOTENGVTextEdit.Properties.ReadOnly = true;
            this.hOTENGVTextEdit.Size = new System.Drawing.Size(227, 22);
            this.hOTENGVTextEdit.TabIndex = 7;
            // 
            // sP_LAY_DSLTC_SVDKGridControl
            // 
            this.sP_LAY_DSLTC_SVDKGridControl.DataSource = this.sP_LAY_DSLTC_SVDKBindingSource;
            this.sP_LAY_DSLTC_SVDKGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sP_LAY_DSLTC_SVDKGridControl.Location = new System.Drawing.Point(416, 437);
            this.sP_LAY_DSLTC_SVDKGridControl.MainView = this.gridView2;
            this.sP_LAY_DSLTC_SVDKGridControl.Name = "sP_LAY_DSLTC_SVDKGridControl";
            this.sP_LAY_DSLTC_SVDKGridControl.Size = new System.Drawing.Size(899, 237);
            this.sP_LAY_DSLTC_SVDKGridControl.TabIndex = 5;
            this.sP_LAY_DSLTC_SVDKGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH1,
            this.colTENMH1,
            this.colNHOM1,
            this.colHOTENGV1});
            this.gridView2.GridControl = this.sP_LAY_DSLTC_SVDKGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.ReadOnly = true;
            // 
            // colMAMH1
            // 
            this.colMAMH1.FieldName = "MAMH";
            this.colMAMH1.MinWidth = 25;
            this.colMAMH1.Name = "colMAMH1";
            this.colMAMH1.Visible = true;
            this.colMAMH1.VisibleIndex = 0;
            this.colMAMH1.Width = 94;
            // 
            // colTENMH1
            // 
            this.colTENMH1.FieldName = "TENMH";
            this.colTENMH1.MinWidth = 25;
            this.colTENMH1.Name = "colTENMH1";
            this.colTENMH1.Visible = true;
            this.colTENMH1.VisibleIndex = 1;
            this.colTENMH1.Width = 94;
            // 
            // colNHOM1
            // 
            this.colNHOM1.FieldName = "NHOM";
            this.colNHOM1.MinWidth = 25;
            this.colNHOM1.Name = "colNHOM1";
            this.colNHOM1.Visible = true;
            this.colNHOM1.VisibleIndex = 2;
            this.colNHOM1.Width = 94;
            // 
            // colHOTENGV1
            // 
            this.colHOTENGV1.FieldName = "HOTENGV";
            this.colHOTENGV1.MinWidth = 25;
            this.colHOTENGV1.Name = "colHOTENGV1";
            this.colHOTENGV1.Visible = true;
            this.colHOTENGV1.VisibleIndex = 3;
            this.colHOTENGV1.Width = 94;
            // 
            // frmDangKyMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 674);
            this.Controls.Add(this.sP_LAY_DSLTC_SVDKGridControl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sP_LOCLTCGridControl);
            this.Controls.Add(this.pnlLocLopTinChi);
            this.Controls.Add(this.pnlThongTinSV);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDangKyMon";
            this.Text = "frmDangKyMon";
            this.Load += new System.EventHandler(this.frmDangKyMon_Load);
            this.pnlThongTinSV.ResumeLayout(false);
            this.pnlThongTinSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNienKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            this.pnlLocLopTinChi.ResumeLayout(false);
            this.pnlLocLopTinChi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LOCLTCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LOCLTCGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAY_DSLTC_SVDKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mAMHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENMHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTENGVTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAY_DSLTC_SVDKGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlThongTinSV;
        private System.Windows.Forms.TextBox teMaLop;
        private System.Windows.Forms.TextBox teHoTen;
        private System.Windows.Forms.TextBox teMaSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMaSV;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsNienKhoa;
        private DSTableAdapters.NIENKHOATableAdapter taNienKhoa;
        private System.Windows.Forms.Button btnXacNhan;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel pnlLocLopTinChi;
        private System.Windows.Forms.ComboBox cmbNienKhoa;
        private System.Windows.Forms.Label lblNienKhoa;
        private System.Windows.Forms.ComboBox cmbHocKy;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.BindingSource sP_LOCLTCBindingSource;
        private DSTableAdapters.SP_LOCLTCTableAdapter sP_LOCLTCTableAdapter;
        private DevExpress.XtraGrid.GridControl sP_LOCLTCGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button btnThoatDangKy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.BindingSource sP_LAY_DSLTC_SVDKBindingSource;
        private DSTableAdapters.SP_LAY_DSLTC_SVDKTableAdapter sP_LAY_DSLTC_SVDKTableAdapter;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl sP_LAY_DSLTC_SVDKGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH1;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH1;
        private DevExpress.XtraGrid.Columns.GridColumn colNHOM1;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTENGV1;
        private DevExpress.XtraEditors.TextEdit mAMHTextEdit;
        private DevExpress.XtraEditors.TextEdit tENMHTextEdit;
        private DevExpress.XtraEditors.SpinEdit nHOMSpinEdit;
        private DevExpress.XtraEditors.TextEdit hOTENGVTextEdit;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colNHOM;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTENGV;
        private DevExpress.XtraGrid.Columns.GridColumn colSLDADANGKY;
        private DevExpress.XtraGrid.Columns.GridColumn colHUYDANGKY;
    }
}