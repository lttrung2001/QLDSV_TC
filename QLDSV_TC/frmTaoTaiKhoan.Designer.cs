namespace QLDSV_TC
{
    partial class frmTaoTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaoTaiKhoan));
            this.cmbGiangVien = new System.Windows.Forms.ComboBox();
            this.lblGiangVien = new System.Windows.Forms.Label();
            this.lblTaoTaiKhoan = new System.Windows.Forms.Label();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblTenNhom = new System.Windows.Forms.Label();
            this.teTaiKhoan = new DevExpress.XtraEditors.TextEdit();
            this.teMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.cmbTenNhom = new System.Windows.Forms.ComboBox();
            this.btnTaoTaiKhoan = new DevExpress.XtraEditors.SimpleButton();
            this.dS = new QLDSV_TC.DS();
            ((System.ComponentModel.ISupportInitialize)(this.teTaiKhoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbGiangVien
            // 
            this.cmbGiangVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGiangVien.FormattingEnabled = true;
            this.cmbGiangVien.Location = new System.Drawing.Point(277, 122);
            this.cmbGiangVien.Name = "cmbGiangVien";
            this.cmbGiangVien.Size = new System.Drawing.Size(537, 31);
            this.cmbGiangVien.TabIndex = 0;
            // 
            // lblGiangVien
            // 
            this.lblGiangVien.AutoSize = true;
            this.lblGiangVien.Location = new System.Drawing.Point(96, 125);
            this.lblGiangVien.Name = "lblGiangVien";
            this.lblGiangVien.Size = new System.Drawing.Size(102, 23);
            this.lblGiangVien.TabIndex = 1;
            this.lblGiangVien.Text = "Giảng viên";
            // 
            // lblTaoTaiKhoan
            // 
            this.lblTaoTaiKhoan.AutoSize = true;
            this.lblTaoTaiKhoan.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaoTaiKhoan.Location = new System.Drawing.Point(144, 39);
            this.lblTaoTaiKhoan.Name = "lblTaoTaiKhoan";
            this.lblTaoTaiKhoan.Size = new System.Drawing.Size(332, 46);
            this.lblTaoTaiKhoan.TabIndex = 2;
            this.lblTaoTaiKhoan.Text = "TẠO TÀI KHOẢN";
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.Location = new System.Drawing.Point(96, 164);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(95, 23);
            this.lblTaiKhoan.TabIndex = 3;
            this.lblTaiKhoan.Text = "Tài khoản";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(96, 204);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(91, 23);
            this.lblMatKhau.TabIndex = 4;
            this.lblMatKhau.Text = "Mật khẩu";
            // 
            // lblTenNhom
            // 
            this.lblTenNhom.AutoSize = true;
            this.lblTenNhom.Location = new System.Drawing.Point(96, 242);
            this.lblTenNhom.Name = "lblTenNhom";
            this.lblTenNhom.Size = new System.Drawing.Size(96, 23);
            this.lblTenNhom.TabIndex = 5;
            this.lblTenNhom.Text = "Tên nhóm";
            // 
            // teTaiKhoan
            // 
            this.teTaiKhoan.Location = new System.Drawing.Point(277, 161);
            this.teTaiKhoan.Margin = new System.Windows.Forms.Padding(5);
            this.teTaiKhoan.Name = "teTaiKhoan";
            this.teTaiKhoan.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teTaiKhoan.Properties.Appearance.Options.UseFont = true;
            this.teTaiKhoan.Properties.MaxLength = 50;
            this.teTaiKhoan.Size = new System.Drawing.Size(537, 30);
            this.teTaiKhoan.TabIndex = 6;
            // 
            // teMatKhau
            // 
            this.teMatKhau.Location = new System.Drawing.Point(277, 201);
            this.teMatKhau.Margin = new System.Windows.Forms.Padding(5);
            this.teMatKhau.Name = "teMatKhau";
            this.teMatKhau.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teMatKhau.Properties.Appearance.Options.UseFont = true;
            this.teMatKhau.Properties.MaxLength = 50;
            this.teMatKhau.Properties.PasswordChar = '*';
            this.teMatKhau.Size = new System.Drawing.Size(537, 30);
            this.teMatKhau.TabIndex = 7;
            // 
            // cmbTenNhom
            // 
            this.cmbTenNhom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenNhom.Enabled = false;
            this.cmbTenNhom.FormattingEnabled = true;
            this.cmbTenNhom.Location = new System.Drawing.Point(277, 239);
            this.cmbTenNhom.Name = "cmbTenNhom";
            this.cmbTenNhom.Size = new System.Drawing.Size(537, 31);
            this.cmbTenNhom.TabIndex = 10;
            // 
            // btnTaoTaiKhoan
            // 
            this.btnTaoTaiKhoan.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoTaiKhoan.Appearance.Options.UseFont = true;
            this.btnTaoTaiKhoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoTaiKhoan.ImageOptions.Image")));
            this.btnTaoTaiKhoan.Location = new System.Drawing.Point(277, 276);
            this.btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            this.btnTaoTaiKhoan.Size = new System.Drawing.Size(120, 36);
            this.btnTaoTaiKhoan.TabIndex = 11;
            this.btnTaoTaiKhoan.Text = "Tạo";
            this.btnTaoTaiKhoan.Click += new System.EventHandler(this.btnTaoTaiKhoan_Click);
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.EnforceConstraints = false;
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmTaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1449, 761);
            this.Controls.Add(this.btnTaoTaiKhoan);
            this.Controls.Add(this.cmbTenNhom);
            this.Controls.Add(this.teMatKhau);
            this.Controls.Add(this.teTaiKhoan);
            this.Controls.Add(this.lblTenNhom);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.lblTaiKhoan);
            this.Controls.Add(this.lblTaoTaiKhoan);
            this.Controls.Add(this.lblGiangVien);
            this.Controls.Add(this.cmbGiangVien);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTaoTaiKhoan";
            this.Text = "TẠO TÀI KHOẢN";
            this.Load += new System.EventHandler(this.frmTaoTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teTaiKhoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbGiangVien;
        private System.Windows.Forms.Label lblGiangVien;
        private System.Windows.Forms.Label lblTaoTaiKhoan;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblTenNhom;
        private DevExpress.XtraEditors.TextEdit teTaiKhoan;
        private DevExpress.XtraEditors.TextEdit teMatKhau;
        private System.Windows.Forms.ComboBox cmbTenNhom;
        private DevExpress.XtraEditors.SimpleButton btnTaoTaiKhoan;
        private DS dS;
    }
}