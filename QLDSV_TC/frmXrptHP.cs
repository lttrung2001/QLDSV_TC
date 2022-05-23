using DevExpress.XtraEditors;
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
    public partial class frmXrptHP : DevExpress.XtraEditors.XtraForm
    {
        public frmXrptHP()
        {
            InitializeComponent();
        }

        private void frmXrptHP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.KHOA' table. You can move, or remove it, as needed.
	    this.kHOATableAdapter.Connection.ConnectionString = Program.connectionString;
            this.kHOATableAdapter.Fill(this.dS.KHOA);
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
	    this.lOPTableAdapter.Connection.ConnectionString = Program.connectionString;  
            this.lOPTableAdapter.Fill(this.dS.LOP);
            // TODO: This line of code loads data into the 'dS.NIENKHOA' table. You can move, or remove it, as needed.
	    this.nIENKHOATableAdapter.Connection.ConnectionString = Program.connectionString;  
            this.nIENKHOATableAdapter.Fill(this.dS.NIENKHOA);
            hocKyComboBox1.SelectedIndex = 0;

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            String tenKhoa = ((DataRowView)kHOABindingSource.Current)["TENKHOA"].ToString();
            string malop = comboBox1.Text;
            String nienKhoa = nIENKHOAComboBox.Text;
            String hocKy = hocKyComboBox1.Text;
            XtrptHP rpt = new XtrptHP(malop, nienKhoa, hocKy);
            // Set datasource cho rpt
            rpt.xrLabel1.Text = String.Format("Mã lớp {0}", malop);
            rpt.xrLabel2.Text = String.Format("Khoa: {0} ", tenKhoa);
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
    }
}