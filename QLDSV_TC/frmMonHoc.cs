﻿using DevExpress.XtraEditors;
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
        private static String option;
        private static String tmpMaMon;
        private static String tmpTenMon;
        private static int tmpStLT;
        private static int tmpStTH;
        private void saveDataWhenChangeSiteOrExitForm()
        {
            if (DS.HasChanges())
            {
                DialogResult msgThoat = MessageBox.Show("Bạn chưa ghi dữ liệu vào CSDL. Bạn có muốn lưu?", "", MessageBoxButtons.YesNo);
                if (msgThoat == DialogResult.Yes)
                {
                    try
                    {
                        bdsMonHoc.EndEdit();
                        MONHOCTableAdapter.Update(DS);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                    }
                }
            }
        }
        private int kiemTraInputMonHoc()
        {
            if (txbMaMonHoc.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống mã môn học!");
                txbMaMonHoc.Focus();
                return 0;
            }
            if (txbTenMonHoc.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống tên môn học!");
                txbTenMonHoc.Focus();
                return 0;
            }
            if (speSoTietLT.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống số tiết lý thuyết!");
                speSoTietLT.Focus();
                return 0;
            }
            if (speSoTietTH.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống số tiết thực hành!");
                speSoTietTH.Focus();
                return 0;
            }
            if ((speSoTietLT.Value + speSoTietTH.Value) % 15 != 0)
            {
                MessageBox.Show("Số tiết lý thuyết và thực hành phải là bội của 15!", "", MessageBoxButtons.OK);
                speSoTietLT.Focus();
                return 0;
            }
            // Code here
            int res = 0;
            if (option == "INSERT")
            {
                res = Program.ExecSqlNonQuery(String.Format("EXEC SP_KIEMTRAMAMON '{0}'", txbMaMonHoc.Text), Program.connectionString);
                if (res != 1) return 0;
                else
                    return 1;
            }
            if (option == "UPDATE")
            {
                if (!txbMaMonHoc.Text.ToString().Equals(tmpMaMon))
                {
                    res = Program.ExecSqlNonQuery(String.Format("EXEC SP_KIEMTRAMAMON '{0}'", txbMaMonHoc.Text), Program.connectionString);
                    if (res != 1) return 0;
                }
                else if (txbTenMonHoc.Text.ToString().Equals(tmpTenMon) && speSoTietLT.Value == tmpStLT && speSoTietTH.Value == tmpStTH)
                    return -1;
            }
            return 1;
        }
        public frmMonHoc()
        {
            InitializeComponent();
            DS.EnforceConstraints = false;
            MONHOCTableAdapter.Connection.ConnectionString = Program.connectionString;
            MONHOCTableAdapter.Fill(DS.MONHOC);
            lOPTINCHITableAdapter.Connection.ConnectionString = Program.connStrSiteChu;
            lOPTINCHITableAdapter.Fill(DS.LOPTINCHI);
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            option = "INSERT";
            // Thay đổi trạng thái các button
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            MONHOCGridControl.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true; // Active nút ghi và nút hủy
            panelControl1.Enabled = true;
            bdsMonHoc.AddNew(); // Thêm dòng mới vào bảng
            txbMaMonHoc.Focus();
        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            MONHOCTableAdapter.Connection.ConnectionString = Program.connectionString;
            MONHOCTableAdapter.Fill(DS.MONHOC);
            lOPTINCHITableAdapter.Connection.ConnectionString = Program.connStrSiteChu;
            lOPTINCHITableAdapter.Fill(DS.LOPTINCHI);
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            saveDataWhenChangeSiteOrExitForm();
            Close();
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            bdsMonHoc.CancelEdit();
            //if (btnThem.Enabled == false) bdsMonHoc.Position = vitri;
            MONHOCGridControl.Enabled = true;
            panelControl1.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            frmMonHoc_Load(sender, e);

            // load lại cả form...


            //if (vitri > 0)
            //{
            //    bdsMonHoc.Position = vitri;
            //}
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsLopTinChi.Count > 0)
            {
                MessageBox.Show("Không thể xóa môn học này vì đã có trong lớp học", "", MessageBoxButtons.OK);
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa môn học này ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    bdsMonHoc.RemoveCurrent(); // Xóa dòng hiện tại
                    bdsMonHoc.EndEdit(); // Lưu dữ liệu về DS
                    MONHOCTableAdapter.Update(DS);
                }
                else return;
            }
            if (bdsMonHoc.Count == 0) btnXoa.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            tmpMaMon = ((DataRowView)bdsMonHoc.Current)["MAMH"].ToString();
            tmpTenMon = ((DataRowView)bdsMonHoc.Current)["TENMH"].ToString();
            tmpStLT = int.Parse(((DataRowView)bdsMonHoc.Current)["SOTIET_LT"].ToString());
            tmpStTH = int.Parse(((DataRowView)bdsMonHoc.Current)["SOTIET_TH"].ToString());
            
            option = "UPDATE";
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true; // Active nút ghi và nút hủy
            panelControl1.Enabled = true;
            MONHOCGridControl.Enabled = false;
            txbMaMonHoc.Focus();
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int flag = kiemTraInputMonHoc();
            if (flag == 1)
            {
                DialogResult dr = XtraMessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        // Thay đổi trạng thái các button
                        bdsMonHoc.EndEdit();
                        bdsMonHoc.ResetCurrentItem();// tự động render để hiển thị dữ liệu mới
                        MONHOCTableAdapter.Update(this.DS.MONHOC);

                    }
                    catch (Exception ex)
                    {
                        bdsMonHoc.RemoveCurrent();
                        XtraMessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (option.ToString().Equals("INSERT"))
                        bdsMonHoc.RemoveCurrent();
                }    
                MONHOCGridControl.Enabled = true;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
                btnGhi.Enabled = btnPhucHoi.Enabled = false;
                panelControl1.Enabled = false;
            }
            else if (flag == -1)
            {
                XtraMessageBox.Show("Dữ liệu Môn Học không có sự thay đổi, ghi thất bại. Vui lòng kiểm tra lại!\n", "Error",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else return;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (option.Equals("INSERT"))
                bdsMonHoc.RemoveCurrent();
            // Nếu là update, khi hủy set lại giá trị cũ
            else if (option.Equals("UPDATE"))
            {
                txbMaMonHoc.Text = tmpMaMon;
                txbTenMonHoc.Text = tmpTenMon;
                speSoTietLT.Value = tmpStLT;
                speSoTietTH.Value = tmpStTH;
            }
            panelControl1.Enabled = false;
            MONHOCGridControl.Enabled = true;
            // Set trạng thái các nút chức năng
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
            btnHuy.Enabled = btnGhi.Enabled = false;
        }
    }
}