using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
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

namespace QLDSV_TC
{
    public partial class frmHocPhi : DevExpress.XtraEditors.XtraForm
    {
        //private static String tmpMaSV;
        //private static bool dangThemHP;
        //private static bool dangSuaHP;
        //private static bool dangThemCTHP;
        //private static bool dangSuaCTHP;
        public frmHocPhi()
        {
            InitializeComponent();
        }



        private void frmHocPhi_Load(object sender, EventArgs e)
        {
            try
            {
                // Kết nối site hiện tại
                if (Program.KetNoi() == 0) return; // Nếu không mở kết nối được thì dừng
                CT_DONGHOCPHITableAdapter.Connection.ConnectionString = Program.connectionString
                this.CT_DONGHOCPHITableAdapter.Fill(this.DS.CT_DONGHOCPHI);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi kết nối database: " + ex.Message);
            }
            contextMenuStrip1.Enabled = false;
        }

        void loadHP()
        {
            string cmd1 = "EXEC [dbo].[SP_GetInfoSV_HP] '" + teMaSV.Text + "'";
            var reader = Program.ExecSqlDataReader(cmd1, Program.connectionString);
            if (reader.HasRows == false)
            {
                MessageBox.Show("Mã sinh viên không tồn tại");
                reader.Close();
                return;
            }
            reader.Read();
            teHoTen.Text = reader.GetString(0);
            teLop.Text = reader.GetString(1);
            reader.Close();
            Program.conn.Close();
            try
            {
                HOCPHITableAdapter.Connection.ConnectionString = Program.connectionString;
                this.HOCPHITableAdapter.Fill(this.DS.HOCPHI, teMaSV.Text.Trim());
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Đã xảy ra lỗi khi học phí của sinh viên!\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            if (teMaSV.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được bỏ trống");
                teMaSV.Focus();
                return;
            }
            loadHP();
            contextMenuStrip1.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = true;
    

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dangThemHP = true;
            // Thay đổi trạng thái các button
            btnThem.Enabled = btnXoa.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true; // Active nút ghi và nút hủy
            // Thay đổi trạng thái các grid
            gcCTDHP.Enabled = false;
            // Lưu mã khoa vào biến
            bdsHocPhi.AddNew(); // Thêm dòng mới vào bảng
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsCTHocPhi.Count != 0)
            {
                XtraMessageBox.Show("Không thể xóa thông tin học phí này vì đã có " +
                    "thông tin chi tiết đóng học phí cho học phí này!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DialogResult msg = MessageBox.Show("Bạn có chắc chắn muốn xóa học phí này?", "", MessageBoxButtons.YesNo);
                if (msg == DialogResult.Yes)
                {
                    try
                    {
                        bdsHocPhi.RemoveCurrent(); // Xóa dòng hiện tại
                        bdsHocPhi.EndEdit();
                        HOCPHITableAdapter.Update(DS);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                    }
                }
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bdsHocPhi.EndEdit();
                HOCPHITableAdapter.Update(DS);
                XtraMessageBox.Show("Đa ghi khoản học phí cho sinh viên thành công!", "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                btnGhi.Enabled = btnHuy.Enabled = true;
                return;
            }
            gcCTDHP.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false; // Active nút ghi và nút hủy
        }


        private void gvDSHP_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            int position = view.FocusedRowHandle;
            String nienKhoa = gvDSHP.GetRowCellValue(position, "NIENKHOA").ToString();
            String hocKy = gvDSHP.GetRowCellValue(position, "HOCKY").ToString();
            String hocPhi = gvDSHP.GetRowCellValue(position, "HOCPHI").ToString();
            btnGhi.Enabled = false;
            if (String.IsNullOrWhiteSpace(nienKhoa))
            {
                MessageBox.Show("Không để trống niên khóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Valid = false;
                view.SetColumnError(colNIENKHOA, "Không để trống niên khóa!");
                return;
            }
            if (String.IsNullOrWhiteSpace(hocKy))
            {
                MessageBox.Show("Không để trống học kỳ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Valid = false;
                view.SetColumnError(colHOCKY, "Không để trống học kỳ!");
                return;
            }
            if (String.IsNullOrWhiteSpace(hocPhi))
            {
                MessageBox.Show("Không để trống học phí!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Valid = false;
                view.SetColumnError(colHOCPHI, "Không để trống học phí!");
                return;
            }
            if (view.IsNewItemRow(position)) // Nếu dòng hiện tại là dòng mới thì ...
            {
                if (kiemTraTrungDSHP(nienKhoa, hocKy) != -1) // Nếu trùng thì ...
                {
                    MessageBox.Show("Đã tồn tại gì đó phiếu học phí này", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Valid = false;
                    view.SetColumnError(colNIENKHOA, "Đã tồn tại niên khóa, xem lại...");
                    view.SetColumnError(colHOCKY, "Đã tồn tại học kì, xem lại...");
                    return;
                }
                else // Không trùng thì
                {
                    btnGhi.Enabled = true;
                }
            }
            else // Trường hợp sửa niên khóa or học ky
            {
                // Code here
                if (kiemTraTrungDSHP_UPDATE(nienKhoa, hocKy, position) != -1) // Nếu trùng thì ...
                {
                    MessageBox.Show("Đã tồn tại gì đó phiếu học phí này", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Valid = false;
                    view.SetColumnError(colNIENKHOA, "Đã tồn tại niên khóa, xem lại...");
                    view.SetColumnError(colHOCKY, "Đã tồn tại học kì, xem lại...");
                    return;
                }
                int hocphi = Int32.Parse(hocPhi);
                int sotiendadong = Int32.Parse(gvDSHP.GetRowCellValue(position, "colDADONGHP").ToString());
                if (hocphi < sotiendadong)
                {
                    MessageBox.Show("Học phí sửa không được nhỏ hơn số tiền đã đóng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Valid = false;
                    view.SetColumnError(colHOCPHI, "xem lại...");
                    return;
                }
                else // Không trùng thì
                {
                    btnGhi.Enabled = true;
                }
            }
        }

        private int kiemTraTrungDSHP_UPDATE(String nienKhoa, String Hocky, int position)
        {
            DataRowView row;
            for (int i = 0; i < bdsHocPhi.Count; i++)
            {
                if (i == position)
                    continue;
                row = (DataRowView)bdsHocPhi[i];
                // Chỉ cần check niên khóa và học kỳ thôi vì khi fill về lọc theo mã sinh viên rồi
                if (nienKhoa.Equals(row["NIENKHOA"].ToString()) && Hocky.Equals(row["HOCKY"].ToString()))
                    return i; // Trung thi tra ve vi tri
            }
            return -1; // Khong trung
        }
        private void gvDSHP_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            // Set giá trị cho dòng mới
            view.SetRowCellValue(e.RowHandle, view.Columns["MASV"], teMaSV.Text);
        }
        private int kiemTraTrungDSHP(String nienKhoa, String Hocky)
        {
            DataRowView row;
            for (int i = 0; i < bdsHocPhi.Count - 1; i++)
            {
                row = (DataRowView)bdsHocPhi[i];
                // Chỉ cần check niên khóa và học kỳ thôi vì khi fill về lọc theo mã sinh viên rồi
                if (nienKhoa.Equals(row["NIENKHOA"].ToString()) && Hocky.Equals(row["HOCKY"].ToString()))
                    return i; // Trung thi tra ve vi tri
            }
            return -1; // Khong trung
        }

        // Tắt lỗi mặc định của gridview
        private void gvDSHP_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
   
            bdsHocPhi.CancelEdit(); // Hủy thao tác hiện tại
            loadHP();
            contextMenuStrip1.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = true;
            btnGhi.Enabled = false;
        }

        private void thêmSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Thay đổi trạng thái các button
            btnThem.Enabled = btnXoa.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = false; // Active nút ghi và nút hủy
            // Thay đổi trạng thái các grid
            gcDSHP.Enabled = false;

            // Lưu mã khoa vào biến
            bdsCTHocPhi.AddNew(); // Thêm dòng mới vào bảngGridView view1 = gvDSHP;
            position = view1.FocusedRowHandle;
            int money = int.Parse(gvDSHP.GetRowCellValue(position, "colCONTHIEU").ToString());
            ((DataRowView)bdsCTHocPhi.Current)["NGAYDONG"] = DateTime.Now.ToString();
            ((DataRowView)bdsCTHocPhi.Current)["SOTIENDONG"] = money;
        }

        private void xóaSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Bạn có chắc chắn muốn xóa học phí này?", "", MessageBoxButtons.YesNo);
            if (msg == DialogResult.Yes)
            {
                try
                {
                    bdsCTHocPhi.RemoveCurrent(); // Xóa dòng hiện tại
                    bdsCTHocPhi.EndEdit();
                    CT_DONGHOCPHITableAdapter.Update(DS);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
            }
        }

        private void ghiVàoCSDLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                bdsCTHocPhi.EndEdit();
                CT_DONGHOCPHITableAdapter.Update(DS);
                XtraMessageBox.Show("Sinh viên đóng học phí thành công!", "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
            gcDSHP.Enabled = true;
            gcCTDHP.Enabled = true;
            btnThem.Enabled = true;
        }

        private void gvCTDHP_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            GridView view1 = gvDSHP;
            int position = view1.FocusedRowHandle;
            int position1 = view.FocusedRowHandle;
            String money = gvCTDHP.GetRowCellValue(position1, "SOTIENDONG").ToString();
            btnGhi.Enabled = false;
            if (String.IsNullOrWhiteSpace(money))
            {
                MessageBox.Show("Không để trống học phí!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Valid = false;
                view.SetColumnError(colSOTIENDONG, "Không để trống số tiền đóng học phí!");
                return;
            }
            int sotienCandong = int.Parse(gvDSHP.GetRowCellValue(position, "colCONTHIEU").ToString());
            if (sotienCandong < 0)
            {
                MessageBox.Show("Số tiền đóng lớn hơn số tiền " + money + " còn lại phải đóng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Valid = false;
                view.SetColumnError(colSOTIENDONG, "Số tiền đóng lớn hơn số tiền còn lại phải đóng,vui lòng xem lại...!");
                return;
            }

        }
        private void gvCTDHP_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void phụcHồiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bdsCTHocPhi.CancelEdit(); // Hủy thao tác hiện tại
            gcDSHP.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = true;

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DS.HasChanges())
            {
                DialogResult msgThoat = MessageBox.Show("Bạn chưa ghi dữ liệu vào CSDL. Bạn có muốn lưu?", "", MessageBoxButtons.YesNo);
                if (msgThoat == DialogResult.Yes)
                {
                    try
                    {
                        bdsHocPhi.EndEdit();
                        HOCPHITableAdapter.Update(DS);
                        bdsCTHocPhi.EndEdit();
                        CT_DONGHOCPHITableAdapter.Update(DS);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                    }
                }
            }
            Close();
        }
    }
}