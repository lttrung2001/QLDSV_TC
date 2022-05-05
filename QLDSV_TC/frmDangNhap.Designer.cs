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
            this.dS = new QLDSV_TC.DS();
            this.teTaiKhoan = new DevExpress.XtraEditors.TextEdit();
            this.teMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.btnDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.dSBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.headingDangNhap.Location = new System.Drawing.Point(572, 84);
            this.headingDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.headingDangNhap.Name = "headingDangNhap";
            this.headingDangNhap.Size = new System.Drawing.Size(239, 46);
            this.headingDangNhap.TabIndex = 0;
            this.headingDangNhap.Text = "ĐĂNG NHẬP";
            // 
            // lblKhoa
            // 
            this.lblKhoa.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhoa.Appearance.Options.UseFont = true;
            this.lblKhoa.Location = new System.Drawing.Point(323, 223);
            this.lblKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(55, 23);
            this.lblKhoa.TabIndex = 1;
            this.lblKhoa.Text = "KHOA";
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaiKhoan.Appearance.Options.UseFont = true;
            this.lblTaiKhoan.Location = new System.Drawing.Point(323, 267);
            this.lblTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(105, 23);
            this.lblTaiKhoan.TabIndex = 2;
            this.lblTaiKhoan.Text = "TÀI KHOẢN";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.Appearance.Options.UseFont = true;
            this.lblMatKhau.Location = new System.Drawing.Point(323, 313);
            this.lblMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(100, 23);
            this.lblMatKhau.TabIndex = 3;
            this.lblMatKhau.Text = "MẬT KHẨU";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DisplayMember = "TENSERVER";
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(480, 215);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(532, 31);
            this.cmbKhoa.TabIndex = 4;
            this.cmbKhoa.ValueMember = "TENSERVER";
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teTaiKhoan
            // 
            this.teTaiKhoan.Location = new System.Drawing.Point(480, 259);
            this.teTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.teTaiKhoan.Name = "teTaiKhoan";
            this.teTaiKhoan.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teTaiKhoan.Properties.Appearance.Options.UseFont = true;
            this.teTaiKhoan.Size = new System.Drawing.Size(532, 30);
            this.teTaiKhoan.TabIndex = 5;
            // 
            // teMatKhau
            // 
            this.teMatKhau.Location = new System.Drawing.Point(480, 304);
            this.teMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.teMatKhau.Name = "teMatKhau";
            this.teMatKhau.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teMatKhau.Properties.Appearance.Options.UseFont = true;
            this.teMatKhau.Properties.PasswordChar = '*';
            this.teMatKhau.Size = new System.Drawing.Size(532, 30);
            this.teMatKhau.TabIndex = 6;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Appearance.Options.UseFont = true;
            this.btnDangNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.ImageOptions.Image")));
            this.btnDangNhap.Location = new System.Drawing.Point(480, 349);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(189, 37);
            this.btnDangNhap.TabIndex = 7;
            this.btnDangNhap.Text = "ĐĂNG NHẬP";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // dSBindingSource
            // 
            this.dSBindingSource.DataSource = this.dS;
            this.dSBindingSource.Position = 0;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 643);
            this.Controls.Add(this.btnDangNhap);
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
        private DevExpress.XtraEditors.SimpleButton btnDangNhap;
        private System.Windows.Forms.BindingSource dSBindingSource;
        private DS dS;
    }
}