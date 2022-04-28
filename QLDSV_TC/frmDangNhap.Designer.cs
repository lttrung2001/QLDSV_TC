namespace QLDSV_TC
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.headingDangNhap = new DevExpress.XtraEditors.LabelControl();
            this.lblKhoa = new DevExpress.XtraEditors.LabelControl();
            this.lblTaiKhoan = new DevExpress.XtraEditors.LabelControl();
            this.lblMatKhau = new DevExpress.XtraEditors.LabelControl();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.vDSPHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLDSV_TC.DS();
            this.teTaiKhoan = new DevExpress.XtraEditors.TextEdit();
            this.teMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.dSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DS_PHANMANHTableAdapter = new QLDSV_TC.DSTableAdapters.V_DS_PHANMANHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTaiKhoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // headingDangNhap
            // 
            this.headingDangNhap.Appearance.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingDangNhap.Appearance.Options.UseFont = true;
            this.headingDangNhap.Appearance.Options.UseTextOptions = true;
            this.headingDangNhap.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.headingDangNhap.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.headingDangNhap.Location = new System.Drawing.Point(458, 67);
            this.headingDangNhap.Name = "headingDangNhap";
            this.headingDangNhap.Size = new System.Drawing.Size(239, 46);
            this.headingDangNhap.TabIndex = 0;
            this.headingDangNhap.Text = "ĐĂNG NHẬP";
            // 
            // lblKhoa
            // 
            this.lblKhoa.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhoa.Appearance.Options.UseFont = true;
            this.lblKhoa.Location = new System.Drawing.Point(227, 219);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(55, 23);
            this.lblKhoa.TabIndex = 1;
            this.lblKhoa.Text = "KHOA";
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaiKhoan.Appearance.Options.UseFont = true;
            this.lblTaiKhoan.Location = new System.Drawing.Point(227, 266);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(105, 23);
            this.lblTaiKhoan.TabIndex = 2;
            this.lblTaiKhoan.Text = "TÀI KHOẢN";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.Appearance.Options.UseFont = true;
            this.lblMatKhau.Location = new System.Drawing.Point(227, 319);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(100, 23);
            this.lblMatKhau.TabIndex = 3;
            this.lblMatKhau.Text = "MẬT KHẨU";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DataSource = this.vDSPHANMANHBindingSource;
            this.cmbKhoa.DisplayMember = "TENCN";
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(357, 216);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(532, 31);
            this.cmbKhoa.TabIndex = 4;
            this.cmbKhoa.ValueMember = "TENSERVER";
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
            // teTaiKhoan
            // 
            this.teTaiKhoan.Location = new System.Drawing.Point(357, 263);
            this.teTaiKhoan.Name = "teTaiKhoan";
            this.teTaiKhoan.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teTaiKhoan.Properties.Appearance.Options.UseFont = true;
            this.teTaiKhoan.Size = new System.Drawing.Size(532, 30);
            this.teTaiKhoan.TabIndex = 5;
            // 
            // teMatKhau
            // 
            this.teMatKhau.Location = new System.Drawing.Point(357, 316);
            this.teMatKhau.Name = "teMatKhau";
            this.teMatKhau.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teMatKhau.Properties.Appearance.Options.UseFont = true;
            this.teMatKhau.Properties.PasswordChar = '*';
            this.teMatKhau.Size = new System.Drawing.Size(532, 30);
            this.teMatKhau.TabIndex = 6;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(357, 352);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(169, 39);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "ĐĂNG NHẬP";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(720, 352);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(169, 39);
            this.simpleButton2.TabIndex = 8;
            this.simpleButton2.Text = "THOÁT";
            // 
            // dSBindingSource
            // 
            this.dSBindingSource.DataSource = this.dS;
            this.dSBindingSource.Position = 0;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 647);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.teMatKhau);
            this.Controls.Add(this.teTaiKhoan);
            this.Controls.Add(this.cmbKhoa);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.lblTaiKhoan);
            this.Controls.Add(this.lblKhoa);
            this.Controls.Add(this.headingDangNhap);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ĐĂNG NHẬP";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTaiKhoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl headingDangNhap;
        private DevExpress.XtraEditors.LabelControl lblKhoa;
        private DevExpress.XtraEditors.LabelControl lblTaiKhoan;
        private DevExpress.XtraEditors.LabelControl lblMatKhau;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private DevExpress.XtraEditors.TextEdit teTaiKhoan;
        private DevExpress.XtraEditors.TextEdit teMatKhau;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.BindingSource dSBindingSource;
        private DS dS;
        private System.Windows.Forms.BindingSource vDSPHANMANHBindingSource;
        private DSTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
    }
}