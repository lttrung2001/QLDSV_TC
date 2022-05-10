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
    public partial class frmLopTinChi : Form
    {
        private static bool dangThemLTC;
        private static bool dangSuaLTC;
        private static String tmpNienKhoa;
        private static decimal tmpHocKy;
        private static decimal tmpNhom;
        private static String tmpMaMon;

        private void saveDataWhenChangeSiteOrExitForm()
        {
            if (dS.HasChanges())
            {
                DialogResult msgThoat = MessageBox.Show("Bạn chưa ghi dữ liệu vào CSDL. Bạn có muốn lưu?", "", MessageBoxButtons.YesNo);
                if (msgThoat == DialogResult.Yes)
                {
                    try
                    {
                        bdsLTC.EndEdit();
                        taLTC.Update(dS.LOPTINCHI);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                    }
                }
            }
        }

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
            if (dangThemLTC ||
                (dangSuaLTC && teNienKhoa.Text.Equals(tmpNienKhoa) &&
                    seHocKy.Value == tmpHocKy &&
                    seNhom.Value == tmpNhom &&
                    cmbMaMH.SelectedValue.ToString().Equals(tmpMaMon)))
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
            // TODO: This line of code loads data into the 'dS.DANGKY' table. You can move, or remove it, as needed.
            this.taDangKyLTC.Fill(this.dS.DANGKY);
            // Đưa danh sách khoa vào combobox Khoa
            cmbKhoa.DataSource = Program.bdsDSPM;
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.ValueMember = "TENSERVER";

            this.taMonHoc.Connection.ConnectionString = Program.connectionString;
            this.taMonHoc.Fill(this.dS.MONHOC);

            this.taGiangVien.Connection.ConnectionString = Program.connectionString;
            this.taGiangVien.Fill(this.dS.GIANGVIENINFO);

            this.taLTC.Connection.ConnectionString = Program.connectionString;
            this.taLTC.Fill(this.dS.LOPTINCHI);
        }

        private void btnThemLTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dangThemLTC = true; // Thể hiện user đang thêm lớp tín chỉ
            // Thay đổi trạng thái các button
            btnThemLTC.Enabled = btnXoaLTC.Enabled = btnSuaLTC.Enabled = btnThoatLTC.Enabled = false;
            btnGhiLTC.Enabled = btnHuyLTC.Enabled = true; // Active nút ghi và nút hủy

            // Thay đổi trạng thái các grid
            pnlKhoa.Enabled = gcLTC.Enabled = false;
            gbLTC.Enabled = true;

            // Lưu mã khoa vào biến
            String maKhoa = ((DataRowView)bdsLTC.Current)["MAKHOA"].ToString();
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
                    taLTC.Fill(dS.LOPTINCHI);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                    return;
                }
                // Hiện lại box mã lớp tín chỉ
                lblMaLTC.Visible = seMaLTC.Visible = true;
                // Reset trạng thái thêm, sửa
                dangThemLTC = dangSuaLTC = false;
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
            dangSuaLTC = true; // Thể hiện user đang sửa lớp tín chỉ
            // Thay đổi trạng thái các button
            btnThemLTC.Enabled = btnXoaLTC.Enabled = btnSuaLTC.Enabled = btnThoatLTC.Enabled = false;
            btnGhiLTC.Enabled = btnHuyLTC.Enabled = true; // Active nút ghi và nút hủy

            // Thay đổi trạng thái các grid
            pnlKhoa.Enabled = gcLTC.Enabled = false;
            gbLTC.Enabled = true;
        }

        private void btnXoaLTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsDangKyLTC.Count != 0)
            {
                MessageBox.Show("Lớp tín chỉ đã có sinh viên đăng ký. Không thể xóa!");
                return;
            }
            try
            {
                bdsLTC.RemoveCurrent();
                taLTC.Update(dS.LOPTINCHI);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btnHuyLTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLTC.CancelEdit();
            // Hiện lại box mã lớp tín chỉ
            lblMaLTC.Visible = seMaLTC.Visible = true;
            // Reset trạng thái thêm, sửa
            dangThemLTC = dangSuaLTC = false;
            // Thay đổi trạng thái các button
            btnThemLTC.Enabled = btnXoaLTC.Enabled = btnSuaLTC.Enabled = btnThoatLTC.Enabled = true;
            btnGhiLTC.Enabled = btnHuyLTC.Enabled = false; // Active nút ghi và nút hủy
                                                           // Thay đổi trạng thái các grid
            pnlKhoa.Enabled = gcLTC.Enabled = true;
            gbLTC.Enabled = false;
        }

        private void btnThoatLTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                Program.KetNoi();
                try
                {
                    taLTC.Connection.ConnectionString = Program.connectionString;
                    taLTC.Fill(dS.LOPTINCHI);
                    taDangKyLTC.Connection.ConnectionString = Program.connectionString;
                    taDangKyLTC.Fill(dS.DANGKY);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
            }
        }
    }
}
