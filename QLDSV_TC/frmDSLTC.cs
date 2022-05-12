using DevExpress.XtraReports.UI;
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
    public partial class frmDSLTC : Form
    {
        public frmDSLTC()
        {
            InitializeComponent();
        }

        private void frmDSLTC_Load(object sender, EventArgs e)
        {
            // Đưa danh sách khoa vào combobox Khoa
            cmbKhoa.DataSource = Program.bdsDSPM;
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.ValueMember = "TENSERVER";

            this.kHOATableAdapter.Connection.ConnectionString = Program.connectionString;
            this.kHOATableAdapter.Fill(this.dS.KHOA);
            this.nIENKHOATableAdapter.Connection.ConnectionString = Program.connectionString;
            this.nIENKHOATableAdapter.Fill(this.dS.NIENKHOA);

            nIENKHOAComboBox.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;

            if (Program.mTenNhom.Equals("PGV")) pnlKhoa.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nienKhoa = nIENKHOAComboBox.Text;
            String hocKy = comboBox1.Text;
            kHOABindingSource.MoveFirst();
            String tenKhoa = ((DataRowView)kHOABindingSource.Current)["TENKHOA"].ToString().ToUpper();
            XrptDSLTC rpt = new XrptDSLTC(nienKhoa, hocKy);
            rpt.label1.Text = "KHOA " + tenKhoa;
            rpt.label2.Text = String.Format("Niên khóa: {0} Học kỳ: {1}", nienKhoa, hocKy);
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
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
                    frmDSLTC_Load(sender,e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
            }
        }
    }
}
