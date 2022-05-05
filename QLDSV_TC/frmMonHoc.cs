using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;

namespace QLDSV_TC
{
    public partial class frmMonHoc : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        private string flagOption;
        private string oldMaMonHoc = "";
        private string oldTenMonHoc = "";
        public frmMonHoc()
        {
            InitializeComponent();
            panelControl1.Enabled = false;
        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            MONHOCTableAdapter.Connection.ConnectionString = Program.connectionString;
            MONHOCTableAdapter.Fill(DS.MONHOC);
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMonHoc.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void mONHOCBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMonHoc.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsMonHoc.Position;
            flagOption = "ADD";
            panelControl1.Enabled = true;
            bdsMonHoc.AddNew();

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            MONHOCGridControl.Enabled = false;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            bdsMonHoc.CancelEdit();
            if (btnThem.Enabled == false) bdsMonHoc.Position = vitri;
            MONHOCGridControl.Enabled = true;
            panelControl1.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            frmMonHoc_Load(sender, e);

            // load lại cả form...


            if (vitri > 0)
            {
                bdsMonHoc.Position = vitri;
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsMonHoc.Position;
            flagOption = "UPDATE";

            oldMaMonHoc = txbMaMonHoc.Text.Trim();
            oldTenMonHoc = txbTenMonHoc.Text.Trim();
            txbMaMonHoc.Enabled = false;
            panelControl1.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = false;
            btnGhi.Enabled = true;
            MONHOCGridControl.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.MONHOCTableAdapter.Fill(this.DS.MONHOC);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl1.Enabled = false;
            MONHOCGridControl.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnGhi.Enabled = true;
        }

        private void gridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle == view.FocusedRowHandle)
            {
                e.Appearance.BackColor = Color.LawnGreen;
            }
        }

        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            e.Handled = true;
            SolidBrush brush = new SolidBrush(Color.FromArgb(0xC6, 0x64, 0xFF));
            e.Graphics.FillRectangle(brush, e.Bounds);
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width - 1, e.Bounds.Height));
            Size size = ImageCollection.GetImageListSize(e.Info.ImageCollection);
            Rectangle r = e.Bounds;
            ImageCollection.DrawImageListImage(e.Cache, e.Info.ImageCollection, e.Info.ImageIndex,
                    new Rectangle(r.X + (r.Width - size.Width) / 2, r.Y + (r.Height - size.Height) / 2, size.Width, size.Height));
            brush.Dispose();
        }
    }
}