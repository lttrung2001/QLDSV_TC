using DevExpress.XtraReports.UI;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class frmBangDiemTongKet : Form
    {
        public frmBangDiemTongKet()
        {
            InitializeComponent();
        }

        private void frmBangDiemTongKet_Load(object sender, EventArgs e)
        {
            this.kHOATableAdapter.Connection.ConnectionString = Program.connectionString;
            this.kHOATableAdapter.Fill(this.dS.KHOA);
            this.lOPTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            // Đưa danh sách khoa vào combobox Khoa
            cmbKhoa.DataSource = Program.bdsDSPM;
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.ValueMember = "TENSERVER";

            comboBox1.SelectedIndex = 0;

            if (Program.mTenNhom.Equals("PGV")) pnlKhoa.Enabled = true;
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Bắt lỗi lần đầu load
            if (cmbKhoa.SelectedValue == null || cmbKhoa.SelectedValue.ToString().Equals("System.Data.DataRowView")) return;
            if (cmbKhoa.SelectedValue.ToString().Equals(Program.servername)) return; // Chọn lại khoa hiện tại thì return
            else // Khoa được chọn khác với khoa hiện tại
            {
                Program.servername = cmbKhoa.SelectedValue.ToString();
                if (Program.KetNoi() == 0) return; // Không kết nối được thì dừng
                try
                {
                    frmBangDiemTongKet_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String maLop = comboBox1.Text;
            String tenKhoa = ((DataRowView)kHOABindingSource[0])["TENKHOA"].ToString().ToUpper();
            XrptBangDiemTongKet rpt = new XrptBangDiemTongKet(maLop);
            rpt.xrLabel1.Text = String.Format("LỚP: {0} - KHÓA HỌC: {1}", maLop, comboBox1.SelectedValue.ToString());
            rpt.xrLabel2.Text = String.Format("KHOA: " + tenKhoa);
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
    }
}
