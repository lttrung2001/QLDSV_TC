using System;
using System.Data;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class frmLopTinChi : Form
    {
        private static String tmpNienKhoa;
        private static int tmpHocKy;
        private static int tmpNhom;
        private static String tmpMaMon;

        public frmLopTinChi()
        {
            InitializeComponent();
            if (Program.mTenNhom.Equals("PGV")) pnlKhoa.Enabled = true;
        }

        private bool kiemTraInputLTC()
        {
            if (teNienKhoa.Text.Trim().Equals(""))
            {
                MessageBox.Show("Không được để trống niên khóa!");
                teNienKhoa.Focus();
                return false;
            }
            if (seHocKy.Text.Equals(""))
            {
                MessageBox.Show("Không được để trống học kỳ!");
                seHocKy.Focus();
                return false;
            }
            if (seHocKy.Value < 1 || seHocKy.Value > 3)
            {
                MessageBox.Show("Giá trị học kỳ là các số 1, 2, 3!");
                seHocKy.Focus();
                return false;
            }
            if (seNhom.Text.Equals(""))
            {
                MessageBox.Show("Không được để trống nhóm!");
                seNhom.Focus();
                return false;
            }
            if (seNhom.Value < 1)
            {
                MessageBox.Show("Nhóm phải lớn hơn 0!");
                seNhom.Focus();
                return false;
            }
            if (seSVMin.Text.Equals(""))
            {
                MessageBox.Show("Không được để trống số lượng sinh viên tối thiểu!");
                seSVMin.Focus();
                return false;
            }
            if (seSVMin.Value <= 0)
            {
                MessageBox.Show("Số lượng sinh viên tối thiểu phải lớn hơn 0!");
                seSVMin.Focus();
                return false;
            }
            // Kiểm tra trùng lớp tín chỉ trong database ở cả 2 phân mảnh
            // Code here
            int res = 1;
            bool isNewRow = gvLTC.IsNewItemRow(gvLTC.FocusedRowHandle);
            if (isNewRow ||
                (!isNewRow && (!teNienKhoa.Text.Equals(tmpNienKhoa) || 
                    !(seHocKy.Value == tmpHocKy) ||
                    !(seNhom.Value == tmpNhom) ||
                    !cmbMaMH.SelectedValue.ToString().Equals(tmpMaMon))))
            {
                res = Program.ExecSqlNonQuery(String.Format("EXEC SP_KIEMTRAMALTC '{0}', {1}, {2}, '{3}'",
                                                            teNienKhoa.Text,
                                                            seHocKy.Value,
                                                            seNhom.Value,
                                                            cmbMaMH.SelectedValue.ToString()
                                                            ),
                                            Program.connectionString);
            }
            if (res == 1)
                return true;
            else
                return false;
        }

        private void frmLopTinChi_Load(object sender, EventArgs e)
        {
            // Đưa danh sách khoa vào combobox Khoa
            cmbKhoa.DataSource = Program.bdsDSPM;
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.ValueMember = "TENSERVER";

            this.taKhoa.Connection.ConnectionString = Program.connectionString;
            this.taKhoa.Fill(this.dS.KHOA);

            this.taMonHoc.Connection.ConnectionString = Program.connectionString;
            this.taMonHoc.Fill(this.dS.MONHOC);

            this.taGiangVien.Connection.ConnectionString = Program.connectionString;
            this.taGiangVien.Fill(this.dS.GIANGVIENINFO);

            this.taLTC.Connection.ConnectionString = Program.connectionString;
            this.taLTC.Fill(this.dS.LOPTINCHI);

            this.taDangKyLTC.Connection.ConnectionString = Program.connectionString;
            this.taDangKyLTC.Fill(this.dS.DANGKY);
        }

        private void btnThemLTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Thay đổi trạng thái các button
            btnThemLTC.Enabled = btnXoaLTC.Enabled = btnSuaLTC.Enabled = btnThoatLTC.Enabled = false;
            btnGhiLTC.Enabled = btnHuyLTC.Enabled = true; // Active nút ghi và nút hủy

            // Thay đổi trạng thái các grid
            pnlKhoa.Enabled = gcLTC.Enabled = false;
            gbLTC.Enabled = true;

            // Lưu mã khoa vào biến
            String maKhoa = ((DataRowView)bdsKhoa[0])["MAKHOA"].ToString();
            bdsLTC.AddNew(); // Thêm dòng mới vào bảng
            lblMaLTC.Visible = seMaLTC.Visible = false; // Ẩn mã lớp tín chỉ khi thêm
            teMaKhoa.Text = maKhoa; // Tự động mã khoa cho dòng mới
            // Set giá trị ban đầu cho dòng mới
            cmbMaGV.SelectedIndex = 0;
            cmbMaMH.SelectedIndex = 0;
            ceHuyLop.Checked = false;
        }

        private void btnGhiLTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (kiemTraInputLTC()) // Không trùng khóa chính thì thực hiện thêm vào DB
            {
                try
                {
                    bdsLTC.EndEdit(); // Lưu vào DS
                    taLTC.Update(dS.LOPTINCHI); // Update về DB
                    taLTC.Fill(dS.LOPTINCHI); // Load lại dữ liệu từ DB về
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi ghi vào CSDL: " + ex.Message);
                    return;
                }
                // Hiện lại box mã lớp tín chỉ
                lblMaLTC.Visible = seMaLTC.Visible = true;
                // Thay đổi trạng thái các button
                btnThemLTC.Enabled = btnXoaLTC.Enabled = btnSuaLTC.Enabled = btnThoatLTC.Enabled = true;
                btnGhiLTC.Enabled = btnHuyLTC.Enabled = false; // Active nút ghi và nút hủy
                // Thay đổi trạng thái các grid
                pnlKhoa.Enabled = gcLTC.Enabled = true;
                gbLTC.Enabled = false;
            }
        }

        private void btnSuaLTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Thay đổi trạng thái các button
            btnThemLTC.Enabled = btnXoaLTC.Enabled = btnSuaLTC.Enabled = btnThoatLTC.Enabled = false;
            btnGhiLTC.Enabled = btnHuyLTC.Enabled = true; // Active nút ghi và nút hủy

            // Thay đổi trạng thái các grid
            pnlKhoa.Enabled = gcLTC.Enabled = false;
            gbLTC.Enabled = true;

            int pos = gvLTC.FocusedRowHandle;
            tmpNienKhoa = gvLTC.GetRowCellValue(pos, "NIENKHOA").ToString();
            tmpHocKy = int.Parse(gvLTC.GetRowCellValue(pos, "HOCKY").ToString());
            tmpNhom = int.Parse(gvLTC.GetRowCellValue(pos, "NHOM").ToString());
            tmpMaMon = gvLTC.GetRowCellValue(pos, "MAMH").ToString();
        }

        private void btnXoaLTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsDangKyLTC.Count != 0)
            {
                MessageBox.Show("Lớp tín chỉ đã có sinh viên đăng ký. Không thể xóa!");
                return;
            }
            DialogResult msg = MessageBox.Show("Bạn có chắc chắn muốn xóa lớp tín chỉ này?", "", MessageBoxButtons.YesNo);
            if (msg == DialogResult.Yes)
            {
                try
                {
                    bdsLTC.RemoveCurrent();
                    taLTC.Update(dS.LOPTINCHI);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi xóa lớp tín chỉ: " + ex.Message);
                }
            }
        }

        private void btnHuyLTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLTC.CancelEdit();
            // Hiện lại box mã lớp tín chỉ
            lblMaLTC.Visible = seMaLTC.Visible = true;
            // Thay đổi trạng thái các button
            btnThemLTC.Enabled = btnXoaLTC.Enabled = btnSuaLTC.Enabled = btnThoatLTC.Enabled = true;
            btnGhiLTC.Enabled = btnHuyLTC.Enabled = false; // Active nút ghi và nút hủy
                                                           // Thay đổi trạng thái các grid
            pnlKhoa.Enabled = gcLTC.Enabled = true;
            gbLTC.Enabled = false;
        }

        private void btnThoatLTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue == null) return; // Dùng để fix lỗi khi nhấn nút thoát (NULL)
            if (cmbKhoa.SelectedValue.ToString().Equals(Program.servername)) return; // Chọn lại khoa hiện tại thì return
            else // Khoa được chọn khác với khoa hiện tại
            {
                Program.servername = cmbKhoa.SelectedValue.ToString();
                if (Program.KetNoi() == 0) return; // Không kết nối được thì dừng
                try
                {
                    frmLopTinChi_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi kết nối: " + ex.Message);
                }
            }
        }
    }
}
