namespace QLDSV_TC
{
    partial class frmDiem
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnHuyNhapDiem = new System.Windows.Forms.Button();
            this.btnGhi = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnHienThiLTC = new System.Windows.Forms.Button();
            this.cmbHocKi = new System.Windows.Forms.ComboBox();
            this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.DS = new QLDSV_TC.DS();
            this.bdsDSLTC = new System.Windows.Forms.BindingSource(this.components);
            this.SP_LAY_DS_LTCTableAdapter = new QLDSV_TC.DSTableAdapters.SP_LAY_DS_LTCTableAdapter();
            this.tableAdapterManager = new QLDSV_TC.DSTableAdapters.TableAdapterManager();
            this.gcLTC = new DevExpress.XtraGrid.GridControl();
            this.gvLTC = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTENGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDiem = new DevExpress.XtraGrid.GridControl();
            this.gvDiem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaSV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiem_CC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiem_GK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiem_CK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiem_HM = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSLTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnHuyNhapDiem);
            this.panelControl1.Controls.Add(this.btnGhi);
            this.panelControl1.Controls.Add(this.btnStart);
            this.panelControl1.Controls.Add(this.btnHienThiLTC);
            this.panelControl1.Controls.Add(this.cmbHocKi);
            this.panelControl1.Controls.Add(this.cmbNienKhoa);
            this.panelControl1.Controls.Add(this.cmbKhoa);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1695, 100);
            this.panelControl1.TabIndex = 0;
            // 
            // btnHuyNhapDiem
            // 
            this.btnHuyNhapDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnHuyNhapDiem.Enabled = false;
            this.btnHuyNhapDiem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyNhapDiem.Location = new System.Drawing.Point(1346, 23);
            this.btnHuyNhapDiem.Name = "btnHuyNhapDiem";
            this.btnHuyNhapDiem.Size = new System.Drawing.Size(93, 48);
            this.btnHuyNhapDiem.TabIndex = 7;
            this.btnHuyNhapDiem.Text = "Hủy nhập điểm";
            this.btnHuyNhapDiem.UseVisualStyleBackColor = false;
            this.btnHuyNhapDiem.Click += new System.EventHandler(this.btnHuyNhapDiem_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGhi.Enabled = false;
            this.btnGhi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhi.Location = new System.Drawing.Point(1490, 23);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(114, 48);
            this.btnGhi.TabIndex = 6;
            this.btnGhi.Text = "Hoàn thành";
            this.btnGhi.UseVisualStyleBackColor = false;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnStart.Enabled = false;
            this.btnStart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(1193, 23);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(93, 48);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Nhập điểm";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnHienThiLTC
            // 
            this.btnHienThiLTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnHienThiLTC.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThiLTC.ForeColor = System.Drawing.Color.Black;
            this.btnHienThiLTC.Location = new System.Drawing.Point(1012, 23);
            this.btnHienThiLTC.Name = "btnHienThiLTC";
            this.btnHienThiLTC.Size = new System.Drawing.Size(116, 48);
            this.btnHienThiLTC.TabIndex = 4;
            this.btnHienThiLTC.Text = "Hiển thị LTC";
            this.btnHienThiLTC.UseVisualStyleBackColor = false;
            this.btnHienThiLTC.Click += new System.EventHandler(this.btnHienThiLTC_Click);
            // 
            // cmbHocKi
            // 
            this.cmbHocKi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHocKi.FormattingEnabled = true;
            this.cmbHocKi.Location = new System.Drawing.Point(891, 35);
            this.cmbHocKi.Name = "cmbHocKi";
            this.cmbHocKi.Size = new System.Drawing.Size(70, 26);
            this.cmbHocKi.TabIndex = 3;
            // 
            // cmbNienKhoa
            // 
            this.cmbNienKhoa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNienKhoa.FormattingEnabled = true;
            this.cmbNienKhoa.Location = new System.Drawing.Point(637, 34);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Size = new System.Drawing.Size(166, 26);
            this.cmbNienKhoa.TabIndex = 2;
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DisplayMember = "TENCN";
            this.cmbKhoa.Enabled = false;
            this.cmbKhoa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(119, 34);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(405, 26);
            this.cmbKhoa.TabIndex = 1;
            this.cmbKhoa.ValueMember = "TENSERVER";
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(834, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Học kì";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(553, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Niên khóa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khoa";
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.EnforceConstraints = false;
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDSLTC
            // 
            this.bdsDSLTC.DataMember = "SP_LAY_DS_LTC";
            this.bdsDSLTC.DataSource = this.DS;
            // 
            // SP_LAY_DS_LTCTableAdapter
            // 
            this.SP_LAY_DS_LTCTableAdapter.ClearBeforeFill = true;
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
            // gcLTC
            // 
            this.gcLTC.DataSource = this.bdsDSLTC;
            this.gcLTC.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcLTC.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.gcLTC.Location = new System.Drawing.Point(0, 100);
            this.gcLTC.MainView = this.gvLTC;
            this.gcLTC.Name = "gcLTC";
            this.gcLTC.Size = new System.Drawing.Size(1695, 220);
            this.gcLTC.TabIndex = 3;
            this.gcLTC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLTC});
            // 
            // gvLTC
            // 
            this.gvLTC.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALTC,
            this.colMAMH,
            this.colTENMH,
            this.colNHOM,
            this.colHOTENGV});
            this.gvLTC.GridControl = this.gcLTC;
            this.gvLTC.Name = "gvLTC";
            this.gvLTC.OptionsBehavior.ReadOnly = true;
            this.gvLTC.OptionsView.ShowViewCaption = true;
            this.gvLTC.ViewCaption = "DANH SÁCH LỚP TÍN CHỈ";
            // 
            // colMALTC
            // 
            this.colMALTC.Caption = "MÃ LỚP TÍN CHỈ";
            this.colMALTC.FieldName = "MALTC";
            this.colMALTC.Name = "colMALTC";
            this.colMALTC.Visible = true;
            this.colMALTC.VisibleIndex = 0;
            // 
            // colMAMH
            // 
            this.colMAMH.Caption = "MÃ MÔN HỌC";
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 1;
            // 
            // colTENMH
            // 
            this.colTENMH.Caption = "TÊN MÔN HỌC";
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 2;
            // 
            // colNHOM
            // 
            this.colNHOM.Caption = "NHÓM";
            this.colNHOM.FieldName = "NHOM";
            this.colNHOM.Name = "colNHOM";
            this.colNHOM.Visible = true;
            this.colNHOM.VisibleIndex = 3;
            // 
            // colHOTENGV
            // 
            this.colHOTENGV.Caption = "HỌ TÊN GIẢNG VIÊN";
            this.colHOTENGV.FieldName = "HOTENGV";
            this.colHOTENGV.Name = "colHOTENGV";
            this.colHOTENGV.Visible = true;
            this.colHOTENGV.VisibleIndex = 4;
            // 
            // gcDiem
            // 
            this.gcDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDiem.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.gcDiem.Location = new System.Drawing.Point(0, 320);
            this.gcDiem.MainView = this.gvDiem;
            this.gcDiem.Name = "gcDiem";
            this.gcDiem.Size = new System.Drawing.Size(1695, 520);
            this.gcDiem.TabIndex = 4;
            this.gcDiem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDiem});
            // 
            // gvDiem
            // 
            this.gvDiem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaSV,
            this.colHoTen,
            this.colDiem_CC,
            this.colDiem_GK,
            this.colDiem_CK,
            this.colDiem_HM});
            this.gvDiem.GridControl = this.gcDiem;
            this.gvDiem.Name = "gvDiem";
            this.gvDiem.OptionsView.ShowViewCaption = true;
            this.gvDiem.ViewCaption = "DANH SÁCH ĐIỂM";
            this.gvDiem.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gvDiem_ValidatingEditor);
            // 
            // colMaSV
            // 
            this.colMaSV.Caption = "MÃ SINH VIÊN";
            this.colMaSV.FieldName = "MASV";
            this.colMaSV.Name = "colMaSV";
            this.colMaSV.OptionsColumn.ReadOnly = true;
            this.colMaSV.Visible = true;
            this.colMaSV.VisibleIndex = 0;
            // 
            // colHoTen
            // 
            this.colHoTen.Caption = "HỌ TÊN";
            this.colHoTen.FieldName = "HOTENSV";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.OptionsColumn.ReadOnly = true;
            this.colHoTen.Visible = true;
            this.colHoTen.VisibleIndex = 1;
            // 
            // colDiem_CC
            // 
            this.colDiem_CC.Caption = "ĐIỂM CHUUYÊN CẦN";
            this.colDiem_CC.FieldName = "DIEM_CC";
            this.colDiem_CC.Name = "colDiem_CC";
            this.colDiem_CC.Visible = true;
            this.colDiem_CC.VisibleIndex = 2;
            // 
            // colDiem_GK
            // 
            this.colDiem_GK.Caption = "ĐIỂM GIỮA KỲ";
            this.colDiem_GK.FieldName = "DIEM_GK";
            this.colDiem_GK.Name = "colDiem_GK";
            this.colDiem_GK.Visible = true;
            this.colDiem_GK.VisibleIndex = 3;
            // 
            // colDiem_CK
            // 
            this.colDiem_CK.Caption = "ĐIỂM CUỐI KỲ";
            this.colDiem_CK.FieldName = "DIEM_CK";
            this.colDiem_CK.Name = "colDiem_CK";
            this.colDiem_CK.Visible = true;
            this.colDiem_CK.VisibleIndex = 4;
            // 
            // colDiem_HM
            // 
            this.colDiem_HM.Caption = "ĐIỂM HẾT MÔN";
            this.colDiem_HM.FieldName = "colDiem_HM";
            this.colDiem_HM.Name = "colDiem_HM";
            this.colDiem_HM.OptionsColumn.AllowEdit = false;
            this.colDiem_HM.OptionsColumn.ReadOnly = true;
            this.colDiem_HM.OptionsColumn.TabStop = false;
            this.colDiem_HM.UnboundDataType = typeof(decimal);
            this.colDiem_HM.UnboundExpression = "Round([DIEM_CC] * 0.1 + [DIEM_GK] * 0.3 + [DIEM_CK] * 0.6, 1)";
            this.colDiem_HM.Visible = true;
            this.colDiem_HM.VisibleIndex = 5;
            // 
            // frmDiem
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1695, 840);
            this.Controls.Add(this.gcDiem);
            this.Controls.Add(this.gcLTC);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDiem";
            this.Text = "ĐIỂM";
            this.Load += new System.EventHandler(this.frmDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSLTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbHocKi;
        private System.Windows.Forms.ComboBox cmbNienKhoa;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private DevExpress.XtraBars.Bar bar1;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnHienThiLTC;
        private DS DS;
        private System.Windows.Forms.BindingSource bdsDSLTC;
        private DSTableAdapters.SP_LAY_DS_LTCTableAdapter SP_LAY_DS_LTCTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcLTC;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLTC;
        private DevExpress.XtraGrid.Columns.GridColumn colMALTC;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colNHOM;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTENGV;
        private DevExpress.XtraGrid.GridControl gcDiem;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDiem;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSV;
        private DevExpress.XtraGrid.Columns.GridColumn colHoTen;
        private DevExpress.XtraGrid.Columns.GridColumn colDiem_CC;
        private DevExpress.XtraGrid.Columns.GridColumn colDiem_GK;
        private DevExpress.XtraGrid.Columns.GridColumn colDiem_CK;
        private DevExpress.XtraGrid.Columns.GridColumn colDiem_HM;
        private System.Windows.Forms.Button btnHuyNhapDiem;
    }
}