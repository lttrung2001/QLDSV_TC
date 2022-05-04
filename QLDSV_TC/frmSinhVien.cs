using System;
using System.Data;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class frmSinhVien : Form
    {
        private static String option;
        private static String tmpMaLop;
        private static String tmpTenLop;
        private static String tmpKhoaHoc;
        private static String tmpMaKhoa;

        private void saveDataWhenChangeSiteOrExitForm()
        {
            if (dS.HasChanges())
            {
                DialogResult msgThoat = MessageBox.Show("Bạn chưa ghi dữ liệu vào CSDL. Bạn có muốn lưu?", "", MessageBoxButtons.YesNo);
                if (msgThoat == DialogResult.Yes)
                {
                    try
                    {
                        bdsLop.EndEdit();
                        bdsSinhVienLop.EndEdit();
                        taLop.Update(dS);
                        taSinhVienLop.Update(dS);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                    }
                }
            }
        }

        private bool kiemTraInputLop()
        {
            if (teMaLop.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống mã lớp!");
                teMaLop.Focus();
                return false;
            }
            if (teTenLop.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống tên lớp!");
                teTenLop.Focus();
                return false;
            }
            if (teKhoaHoc.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống khóa học!");
                teKhoaHoc.Focus();
                return false;
            }
            // Kiểm tra trùng mã lớp trong database ở cả 2 phân mảnh
            // Code here
            return true;
        }
        public frmSinhVien()
        {
            InitializeComponent();
            if (Program.mTenNhom.Equals("PGV")) pnlKhoa.Enabled = true;
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            cmbKhoa.DataSource = Program.bdsDSPM;
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.ValueMember = "TENSERVER";

            // Disable ràng buộc
            dS.EnforceConstraints = false;

            taLop.Connection.ConnectionString = Program.connectionString;
            taLop.Fill(dS.LOP);

            taSinhVienLop.Connection.ConnectionString = Program.connectionString;
            taSinhVienLop.Fill(dS.SINHVIEN);

            taDangKy.Connection.ConnectionString = Program.connectionString;
            taDangKy.Fill(dS.DANGKY);
        }

        private void btnThemLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            option = "INSERT";
            // Thay đổi trạng thái các button
            btnThemLop.Enabled = btnXoaLop.Enabled = btnSuaLop.Enabled = false;
            btnGhiLop.Enabled = btnHuy.Enabled = true; // Active nút ghi và nút hủy

            // Thay đổi trạng thái các grid
            pnlKhoa.Enabled = gcLop.Enabled = gcSinhVienLop.Enabled = false;
            gbThongTinLop.Enabled = true;

            // Lưu mã khoa vào biến
            String maKhoa = ((DataRowView)bdsLop[bdsLop.Position])["MAKHOA"].ToString();
            bdsLop.AddNew(); // Thêm dòng mới vào bảng
            teMaKhoa.Text = maKhoa;

            teMaLop.Focus();
        }

        private void btnGhiLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Kiểm tra input
            if (kiemTraInputLop())
            {
                // Thay đổi trạng thái các button
                btnThemLop.Enabled = btnXoaLop.Enabled = btnSuaLop.Enabled = true;
                btnGhiLop.Enabled = btnHuy.Enabled = false; // Active nút ghi và nút hủy

                // Thay đổi trạng thái các grid
                pnlKhoa.Enabled = gcLop.Enabled = gcSinhVienLop.Enabled = true;
                gbThongTinLop.Enabled = false;
                try
                {
                    // Lưu lại mã lớp ban đầu
                    String maLop = ((DataRowView)bdsLop[bdsLop.Position])["MALOP"].ToString();
                    bdsLop.EndEdit(); // Dừng edit và lưu data vào DS
                    taLop.Update(dS); // Update về DB
                    // Nếu chỉnh sửa mã lớp thì load lại sinh viên (vì mã lớp đã thay đổi)
                    if (!teMaLop.Text.Equals(maLop))
                        taSinhVienLop.Fill(dS.SINHVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
            }
        }

        private void btnXoaLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsSinhVienLop.Count != 0)
                MessageBox.Show("Lớp có sinh viên. Không thể xóa!");
            else
            {
                bdsLop.RemoveCurrent();
                btnGhiLop.Enabled = true;
            }
        }

        private void btnSuaLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Lưu giá trị trước khi sửa vào biến tạm
            tmpMaLop = ((DataRowView)bdsLop.Current)["MALOP"].ToString();
            tmpTenLop = ((DataRowView)bdsLop.Current)["TENLOP"].ToString();
            tmpKhoaHoc = ((DataRowView)bdsLop.Current)["KHOAHOC"].ToString();
            tmpMaKhoa = ((DataRowView)bdsLop.Current)["MAKHOA"].ToString();
            option = "UPDATE";
            // Thay đổi trạng thái các button
            btnThemLop.Enabled = btnXoaLop.Enabled = btnSuaLop.Enabled = false;
            btnGhiLop.Enabled = btnHuy.Enabled = true; // Active nút ghi và nút hủy

            // Thay đổi trạng thái các grid
            pnlKhoa.Enabled = gcLop.Enabled = gcSinhVienLop.Enabled = false;
            gbThongTinLop.Enabled = true;

            teMaLop.Focus();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            saveDataWhenChangeSiteOrExitForm();
            Close();
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue == null) return; // Dùng để fix lỗi khi nhấn nút thoát (NULL)
            if (cmbKhoa.SelectedIndex == Program.index) return; // Nếu trùng với giá trị cũ
            else // Giá trị khác với giá trị trước đó
            {
                saveDataWhenChangeSiteOrExitForm();
                // Nếu giá trị được chọn là site giống với site được chọn khi đăng nhập
                if (cmbKhoa.SelectedValue.ToString().Equals(Program.servername))
                {
                    Program.KetNoi();
                    try
                    {
                        Program.index = cmbKhoa.SelectedIndex;
                        taLop.Connection.ConnectionString = Program.connectionString;
                        taLop.Fill(dS.LOP);
                        taSinhVienLop.Connection.ConnectionString = Program.connectionString;
                        taSinhVienLop.Fill(dS.SINHVIEN);
                        taDangKy.Connection.ConnectionString = Program.connectionString;
                        taDangKy.Fill(dS.DANGKY);
                    }
                     catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                    }
                }
                // Nếu giá trị được chọn là site khác với site được chọn khi đăng nhập
                else
                {
                    try
                    {
                        Program.connectionString = String.Format("Data Source={0};Initial Catalog={1};User ID={2};password={3}",
                                                            cmbKhoa.SelectedValue.ToString(),
                                                            Program.database,
                                                            Program.remoteLogin,
                                                            Program.remotePassword);
                        Program.index = cmbKhoa.SelectedIndex;
                        taLop.Connection.ConnectionString = Program.connectionString;
                        taLop.Fill(dS.LOP);
                        taSinhVienLop.Connection.ConnectionString = Program.connectionString;
                        taSinhVienLop.Fill(dS.SINHVIEN);
                        taDangKy.Connection.ConnectionString = Program.connectionString;
                        taDangKy.Fill(dS.DANGKY);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                    }
                }
            }
        }

        private void thêmSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bdsSinhVienLop.AddNew();
            ((DataRowView)bdsSinhVienLop[bdsSinhVienLop.Position])["MALOP"] = teMaLop.Text;
        }

        private void ghiVàoCSDLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                bdsSinhVienLop.EndEdit();
                taSinhVienLop.Update(dS);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void xóaSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bdsDangKy.Count != 0) // Sinh viên đã đăng ký lớp tín chỉ
            {
                MessageBox.Show("Sinh viên đã học. Không thể xóa!");
                return;
            }
            try
            {
                bdsSinhVienLop.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void pnlKhoa_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPhucHoiLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (option.Equals("INSERT"))
                bdsLop.RemoveCurrent();
            else if (option.Equals("UPDATE"))
            {
                teMaLop.Text = tmpMaLop;
                teTenLop.Text = tmpTenLop;
                teKhoaHoc.Text = tmpKhoaHoc;
                teMaKhoa.Text = tmpMaKhoa;
            }
            pnlKhoa.Enabled = gcLop.Enabled = gcSinhVienLop.Enabled = true;
            gbThongTinLop.Enabled = false;
            // Set trạng thái các nút chức năng
            btnThemLop.Enabled = btnXoaLop.Enabled = btnSuaLop.Enabled = true;
            btnHuy.Enabled = btnGhiLop.Enabled = false;
        }
    }
}
