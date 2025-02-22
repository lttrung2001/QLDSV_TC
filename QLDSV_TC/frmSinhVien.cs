﻿using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class frmSinhVien : Form
    {
        private static String tmpMaLop;
        private static String tmpMaSV;

        private void saveDataWhenChangeSiteOrExitForm()
        {
            if (dS.HasChanges())
            {
                DialogResult msgThoat = MessageBox.Show("Bạn chưa ghi dữ liệu vào CSDL. Bạn có muốn lưu?", "", MessageBoxButtons.YesNo);
                if (msgThoat == DialogResult.Yes)
                {
                    try
                    {
                        bdsSinhVienLop.EndEdit();
                        taSinhVienLop.Update(dS);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi ghi vào CSDL: " + ex.Message);
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
            int res = Program.ExecSqlNonQuery(String.Format("EXEC SP_KIEMTRAMALOP '{0}'", teMaLop.Text), Program.connectionString);
            if (res == 1) return true;
            else
            {
                teMaLop.Focus();
                return false;
            }
        }

        public frmSinhVien()
        {
            InitializeComponent();
            if (Program.mTenNhom.Equals("PGV")) pnlKhoa.Enabled = true;
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {

            // Đưa danh sách khoa vào combobox Khoa
            cmbKhoa.DataSource = Program.bdsDSPM;
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.ValueMember = "TENSERVER";

            taKhoa.Connection.ConnectionString = Program.connectionString;
            taKhoa.Fill(this.dS.KHOA);

            taLop.Connection.ConnectionString = Program.connectionString;
            taLop.Fill(dS.LOP);

            taSinhVienLop.Connection.ConnectionString = Program.connectionString;
            taSinhVienLop.Fill(dS.SINHVIEN);

            taDangKy.Connection.ConnectionString = Program.connectionString;
            taDangKy.Fill(dS.DANGKY);
        }

        private void btnThemLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Thay đổi trạng thái các button
            btnThemLop.Enabled = btnXoaLop.Enabled = btnSuaLop.Enabled = false;
            btnGhiLop.Enabled = btnHuy.Enabled = true; // Active nút ghi và nút hủy

            // Thay đổi trạng thái các grid
            pnlKhoa.Enabled = gcLop.Enabled = gcSinhVienLop.Enabled = false;
            gbThongTinLop.Enabled = true;

            // Lưu mã khoa vào biến
            String maKhoa = ((DataRowView)bdsKhoa[0])["MAKHOA"].ToString();
            bdsLop.AddNew(); // Thêm dòng mới vào bảng
            teMaKhoa.Text = maKhoa;

            teMaLop.Focus();
        }

        private void btnGhiLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Kiểm tra input
            bool flag = true;
            bool isNewRow = gvLop.IsNewItemRow(gvLop.FocusedRowHandle);
            // Nếu đang thêm lớp hoặc đang sửa mà sửa mã lớp thì check lại
            if (isNewRow || (!isNewRow && !teMaLop.Text.Equals(tmpMaLop))) flag = kiemTraInputLop();
            if (flag) // Cho phép update về DB
            {
                // Thay đổi trạng thái các button
                btnThemLop.Enabled = btnXoaLop.Enabled = btnSuaLop.Enabled = true;
                btnGhiLop.Enabled = btnHuy.Enabled = false; // Active nút ghi và nút hủy

                // Thay đổi trạng thái các grid
                pnlKhoa.Enabled = gcLop.Enabled = gcSinhVienLop.Enabled = true;
                gbThongTinLop.Enabled = false;
                try
                {
                    bdsLop.EndEdit(); // Dừng edit và lưu data vào DS
                    taLop.Update(dS); // Update về DB
                    // Nếu chỉnh sửa mã lớp thì load lại sinh viên (vì mã lớp đã thay đổi)
                    if (!teMaLop.Text.Equals(tmpMaLop))
                        taSinhVienLop.Fill(dS.SINHVIEN);
                    // Reset trạng thái biến
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi ghi vào CSDL: " + ex.Message);
                }
            }
        }

        private void btnXoaLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsSinhVienLop.Count != 0)
                MessageBox.Show("Lớp có sinh viên. Không thể xóa!");
            else
            {
                DialogResult msg = MessageBox.Show("Bạn có chắc chắn muốn xóa lớp này?", "", MessageBoxButtons.YesNo);
                if (msg == DialogResult.Yes)
                {
                    try
                    {
                        bdsLop.RemoveCurrent(); // Xóa dòng hiện tại
                        bdsLop.EndEdit(); // Lưu dữ liệu về DS
                        taLop.Update(dS); // Update dữ liệu DS về DB
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi xóa lớp: " + ex.Message);
                    }
                }
            }
        }

        private void btnSuaLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Lưu giá trị trước khi sửa vào biến tạm
            tmpMaLop = ((DataRowView)bdsLop.Current)["MALOP"].ToString();

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
            if (cmbKhoa.SelectedValue.ToString().Equals(Program.servername)) return; // Chọn lại khoa hiện tại thì return
            else // Khoa được chọn khác với khoa hiện tại
            {
                saveDataWhenChangeSiteOrExitForm();
                Program.servername = cmbKhoa.SelectedValue.ToString();
                if (Program.KetNoi() == 0) return; // Không kết nối được thì dừng
                try
                {
                    frmSinhVien_Load(sender,e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi kết nối: " + ex.Message);
                }
            }
        }

        private void thêmSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bdsSinhVienLop.AddNew();
            gvSinhVienLop.ShowEditForm();
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
                MessageBox.Show("Đã xảy ra lỗi khi ghi vào CSDL: " + ex.Message);
            }
        }

        private void xóaSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Lấy mã để chạy SP
            String masv = ((DataRowView)bdsSinhVienLop.Current)["MASV"].ToString();
            // Kiểm tra sinh viên đóng học phí
            if (Program.ExecSqlNonQuery(String.Format("EXEC SP_KIEMTRAHOCPHISV {0}", masv), Program.connectionString) == 0) return;
            else if (bdsDangKy.Count != 0) // Sinh viên đã đăng ký lớp tín chỉ
                MessageBox.Show("Sinh viên đã đăng ký lớp tín chỉ. Không thể xóa!");
            else
            {
                DialogResult msg = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "", MessageBoxButtons.YesNo);
                if (msg == DialogResult.Yes)
                {
                    try
                    {
                        bdsSinhVienLop.RemoveCurrent();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi xóa sinh viên: " + ex.Message);
                    }
                }
            }
        }

        private void btnPhucHoiLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        // Hàm này dùng để hủy thao tác hiện tại
        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLop.CancelEdit();

            pnlKhoa.Enabled = gcLop.Enabled = gcSinhVienLop.Enabled = true;
            gbThongTinLop.Enabled = false;

            // Set trạng thái các nút chức năng
            btnThemLop.Enabled = btnXoaLop.Enabled = btnSuaLop.Enabled = true;
            btnHuy.Enabled = btnGhiLop.Enabled = false;
        }


        // Hàm tham khảo
        // Khởi tạo giá trị cho dòng mới
        private void gvSinhVienLop_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            // Set giá trị cho dòng mới
            view.SetRowCellValue(e.RowHandle, view.Columns["DANGHIHOC"], 0);
            view.SetRowCellValue(e.RowHandle, view.Columns["PHAI"], 1);
            view.SetRowCellValue(e.RowHandle, view.Columns["MALOP"], teMaLop.Text);
        }

        // Hàm này kiểm tra ràng buộc đối với các giá trị nhập vào của dòng hiện tại
        private void gvSinhVienLop_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            int position = view.FocusedRowHandle;
            String masv = gvSinhVienLop.GetRowCellValue(position, "MASV").ToString();
            String ho = gvSinhVienLop.GetRowCellValue(position, "HO").ToString();
            String ten = gvSinhVienLop.GetRowCellValue(position, "TEN").ToString();
            // Nếu mã sinh viên rỗng
            if (String.IsNullOrWhiteSpace(masv))
            {
                MessageBox.Show("Mã sinh viên không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Valid = false;
                view.SetColumnError(colMASV, "Không để trống mã sinh viên!");
            }
            else // Mã sinh viên không rỗng
            {
                int res = 1;
                bool isNewRow = gvSinhVienLop.IsNewItemRow(gvSinhVienLop.FocusedRowHandle);

                // Nếu thêm mới hoặc sửa mã sinh viên thì phải kiểm tra mã
                if (isNewRow || (!isNewRow && !masv.Equals(tmpMaSV))) // Thêm hoặc sửa mã sinh viên thì kiểm tra
                    res = Program.ExecSqlNonQuery(String.Format("EXEC SP_KIEMTRAMASV '{0}'", masv), Program.connectionString);
                if (res == 0) // Mã sinh viên bị trùng
                {
                    e.Valid = false;
                    view.SetColumnError(colMASV, "Mã sinh viên đã tồn tại!");
                }
                else // Mã sinh viên không trùng
                {
                    if (String.IsNullOrWhiteSpace(ho)) // Kiểm tra họ khác rỗng
                    {
                        MessageBox.Show("Họ không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        e.Valid = false;
                        view.SetColumnError(colHO, "Không để trống họ!");
                    }
                    else if (String.IsNullOrWhiteSpace(ten)) // Kiểm tra tên khác rỗng
                    {
                        MessageBox.Show("Tên không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        e.Valid = false;
                        view.SetColumnError(colTEN, "Không để trống tên!");
                    }
                }
            }
        }

        // Tắt lỗi mặc định của gridview
        private void gvSinhVienLop_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        // Hàm này lưu lại mã sinh viên trước khi sửa bổ trợ cho hàm validate
        private void gvSinhVienLop_EditFormShowing(object sender, EditFormShowingEventArgs e)
        {
            tmpMaSV = ((DataRowView)bdsSinhVienLop.Current)["MASV"].ToString();
        }

        private void gvSinhVienLop_PreparedEditForm(object sender, EditFormPreparedEventArgs e)
        {
            (e.BindableControls["MASV"] as TextEdit).Properties.MaxLength = 10;
            (e.BindableControls["HO"] as TextEdit).Properties.MaxLength = 50;
            (e.BindableControls["TEN"] as TextEdit).Properties.MaxLength = 10;
            (e.BindableControls["DIACHI"] as TextEdit).Properties.MaxLength = 100;
            (e.BindableControls["MALOP"] as TextEdit).Properties.MaxLength = 10;
            (e.BindableControls["PASSWORD"] as TextEdit).Properties.MaxLength = 40;
        }

        private void sửaSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gvSinhVienLop.ShowEditForm();
        }

        private void gvLop_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (bdsSinhVienLop.Count == 0)
            {
                sửaSinhViênToolStripMenuItem.Enabled = false;
                xóaSinhViênToolStripMenuItem.Enabled = false;
            }
            else
            {
                sửaSinhViênToolStripMenuItem.Enabled = true;
                xóaSinhViênToolStripMenuItem.Enabled = true;
            }
        }
    }
}
