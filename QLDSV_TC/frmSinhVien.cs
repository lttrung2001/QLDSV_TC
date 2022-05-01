using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class frmSinhVien : Form
    {
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            try
            {
                // Kết nối bằng tài khoản hiện tại
                this.taLop.Connection.ConnectionString = Program.connectionString;
                this.taSinhVien.Connection.ConnectionString = Program.connectionString;
                // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
                this.taLop.Fill(this.dS.LOP);
                // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
                this.taSinhVien.Fill(this.dS.SINHVIEN);
            }
            catch
            {
                MessageBox.Show("Không có quyền!");
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bdsLop.EndEdit();
                bdsSinhVien.EndEdit();
                if (dS.HasChanges())
                {
                    taLop.Update(this.dS.LOP);
                    taSinhVien.Update(this.dS.SINHVIEN);
                }
                MessageBox.Show("Ghi thành công!");
            }
            catch
            {
                MessageBox.Show("Có lỗi rồi nè huhu!");
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnInDanhSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsSinhVien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void sINHVIENBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void sINHVIENGridControl_Click(object sender, EventArgs e)
        {

        }

        private void lOPBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void gcLop_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void lOPGridControl_Click(object sender, EventArgs e)
        {

        }

        private void lOPGridControl_Click_1(object sender, EventArgs e)
        {

        }

        private void infoSV_Enter(object sender, EventArgs e)
        {

        }

        private void gcLop_Click_1(object sender, EventArgs e)
        {

        }

        private void mALOPTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void mALOPLabel_Click(object sender, EventArgs e)
        {

        }

        private void kHOAHOCLabel_Click(object sender, EventArgs e)
        {

        }

        private void tENLOPLabel_Click(object sender, EventArgs e)
        {

        }

        private void mAKHOALabel_Click(object sender, EventArgs e)
        {

        }

        private void sINHVIENGridControl_Click_1(object sender, EventArgs e)
        {

        }
    }
}
