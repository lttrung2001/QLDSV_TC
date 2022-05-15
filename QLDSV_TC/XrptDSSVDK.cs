using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class XrptDSSVDK : DevExpress.XtraReports.UI.XtraReport
    {
        public XrptDSSVDK()
        {
            InitializeComponent();
        }

        public XrptDSSVDK(String nienKhoa, String hocKy, String maMon, String nhom)
        {
            InitializeComponent();
            sqlDataSource1.Connection.ConnectionString = "XpoProvider=MSSqlServer;" + Program.connectionString;
            sqlDataSource1.Queries[0].Parameters[0].Value = nienKhoa;
            sqlDataSource1.Queries[0].Parameters[1].Value = int.Parse(hocKy);
            sqlDataSource1.Queries[0].Parameters[2].Value = maMon;
            sqlDataSource1.Queries[0].Parameters[3].Value = int.Parse(nhom);
            sqlDataSource1.Fill();
        }
    }
}
