using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV_TC
{
    public partial class XrptDSLTC : DevExpress.XtraReports.UI.XtraReport
    {
        public XrptDSLTC()
        {
            InitializeComponent();
        }
        public XrptDSLTC(String nienKhoa, String hocKy)
        {
            InitializeComponent();
            sqlDataSource1.Connection.ConnectionString = Program.connectionString;
            sqlDataSource1.Queries[0].Parameters[0].Value = nienKhoa;
            sqlDataSource1.Queries[0].Parameters[1].Value = int.Parse(hocKy);
            sqlDataSource1.Fill();
        }
    }
}
