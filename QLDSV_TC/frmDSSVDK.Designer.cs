namespace QLDSV_TC
{
    partial class frmDSSVDK
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
            System.Windows.Forms.Label nIENKHOALabel;
            System.Windows.Forms.Label nIENKHOALabel1;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.dS = new QLDSV_TC.DS();
            this.nIENKHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nIENKHOATableAdapter = new QLDSV_TC.DSTableAdapters.NIENKHOATableAdapter();
            this.tableAdapterManager = new QLDSV_TC.DSTableAdapters.TableAdapterManager();
            this.mONHOCTableAdapter = new QLDSV_TC.DSTableAdapters.MONHOCTableAdapter();
            this.nIENKHOAComboBox = new System.Windows.Forms.ComboBox();
            this.hocKyComboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.button1 = new System.Windows.Forms.Button();
            this.textEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.kHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHOATableAdapter = new QLDSV_TC.DSTableAdapters.KHOATableAdapter();
            this.pnlKhoa = new DevExpress.XtraEditors.PanelControl();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.lblKhoa = new System.Windows.Forms.Label();
            nIENKHOALabel = new System.Windows.Forms.Label();
            nIENKHOALabel1 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIENKHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlKhoa)).BeginInit();
            this.pnlKhoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // nIENKHOALabel
            // 
            nIENKHOALabel.AutoSize = true;
            nIENKHOALabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nIENKHOALabel.Location = new System.Drawing.Point(10, 81);
            nIENKHOALabel.Name = "nIENKHOALabel";
            nIENKHOALabel.Size = new System.Drawing.Size(96, 23);
            nIENKHOALabel.TabIndex = 1;
            nIENKHOALabel.Text = "Niên khóa";
            // 
            // nIENKHOALabel1
            // 
            nIENKHOALabel1.AutoSize = true;
            nIENKHOALabel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nIENKHOALabel1.Location = new System.Drawing.Point(10, 118);
            nIENKHOALabel1.Name = "nIENKHOALabel1";
            nIENKHOALabel1.Size = new System.Drawing.Size(70, 23);
            nIENKHOALabel1.TabIndex = 2;
            nIENKHOALabel1.Text = "Học kỳ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(10, 155);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(60, 23);
            label1.TabIndex = 4;
            label1.Text = "Nhóm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(10, 192);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(85, 23);
            label2.TabIndex = 6;
            label2.Text = "Môn học";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.EnforceConstraints = false;
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nIENKHOABindingSource
            // 
            this.nIENKHOABindingSource.DataMember = "NIENKHOA";
            this.nIENKHOABindingSource.DataSource = this.dS;
            // 
            // nIENKHOATableAdapter
            // 
            this.nIENKHOATableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_TC.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // nIENKHOAComboBox
            // 
            this.nIENKHOAComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nIENKHOABindingSource, "NIENKHOA", true));
            this.nIENKHOAComboBox.DataSource = this.nIENKHOABindingSource;
            this.nIENKHOAComboBox.DisplayMember = "NIENKHOA";
            this.nIENKHOAComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nIENKHOAComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nIENKHOAComboBox.FormattingEnabled = true;
            this.nIENKHOAComboBox.Location = new System.Drawing.Point(134, 78);
            this.nIENKHOAComboBox.Name = "nIENKHOAComboBox";
            this.nIENKHOAComboBox.Size = new System.Drawing.Size(181, 31);
            this.nIENKHOAComboBox.TabIndex = 2;
            this.nIENKHOAComboBox.ValueMember = "NIENKHOA";
            // 
            // hocKyComboBox1
            // 
            this.hocKyComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nIENKHOABindingSource, "NIENKHOA", true));
            this.hocKyComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hocKyComboBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hocKyComboBox1.FormattingEnabled = true;
            this.hocKyComboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.hocKyComboBox1.Location = new System.Drawing.Point(134, 115);
            this.hocKyComboBox1.Name = "hocKyComboBox1";
            this.hocKyComboBox1.Size = new System.Drawing.Size(181, 31);
            this.hocKyComboBox1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nIENKHOABindingSource, "NIENKHOA", true));
            this.comboBox1.DataSource = this.mONHOCBindingSource;
            this.comboBox1.DisplayMember = "TENMH";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(134, 188);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(334, 31);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.ValueMember = "MAMH";
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.dS;
            // 
            // textEdit2
            // 
            this.textEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mONHOCBindingSource, "MAMH", true));
            this.textEdit2.Location = new System.Drawing.Point(474, 189);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit2.Properties.Appearance.Options.UseFont = true;
            this.textEdit2.Properties.ReadOnly = true;
            this.textEdit2.Size = new System.Drawing.Size(118, 30);
            this.textEdit2.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(134, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "Xem báo cáo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.textEdit1.Location = new System.Drawing.Point(134, 152);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit1.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.textEdit1.Properties.IsFloatValue = false;
            this.textEdit1.Properties.MaskSettings.Set("mask", "N00");
            this.textEdit1.Properties.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.textEdit1.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.textEdit1.Size = new System.Drawing.Size(181, 30);
            this.textEdit1.TabIndex = 5;
            // 
            // kHOABindingSource
            // 
            this.kHOABindingSource.DataMember = "KHOA";
            this.kHOABindingSource.DataSource = this.dS;
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
            // 
            // pnlKhoa
            // 
            this.pnlKhoa.Controls.Add(this.cmbKhoa);
            this.pnlKhoa.Controls.Add(this.lblKhoa);
            this.pnlKhoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKhoa.Enabled = false;
            this.pnlKhoa.Location = new System.Drawing.Point(0, 0);
            this.pnlKhoa.Name = "pnlKhoa";
            this.pnlKhoa.Size = new System.Drawing.Size(884, 55);
            this.pnlKhoa.TabIndex = 10;
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(234, 12);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(445, 31);
            this.cmbKhoa.TabIndex = 1;
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
            // frmDSSVDK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 650);
            this.Controls.Add(this.pnlKhoa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(label1);
            this.Controls.Add(nIENKHOALabel1);
            this.Controls.Add(this.hocKyComboBox1);
            this.Controls.Add(nIENKHOALabel);
            this.Controls.Add(this.nIENKHOAComboBox);
            this.Controls.Add(this.textEdit1);
            this.Name = "frmDSSVDK";
            this.Text = "DANH SÁCH SINH VIÊN ĐĂNG KÝ LỚP TÍN CHỈ";
            this.Load += new System.EventHandler(this.frmDSSVDK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIENKHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlKhoa)).EndInit();
            this.pnlKhoa.ResumeLayout(false);
            this.pnlKhoa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DS dS;
        private System.Windows.Forms.BindingSource nIENKHOABindingSource;
        private DSTableAdapters.NIENKHOATableAdapter nIENKHOATableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox nIENKHOAComboBox;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.ComboBox hocKyComboBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.SpinEdit textEdit1;
        private System.Windows.Forms.BindingSource kHOABindingSource;
        private DSTableAdapters.KHOATableAdapter kHOATableAdapter;
        private DevExpress.XtraEditors.PanelControl pnlKhoa;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label lblKhoa;
    }
}