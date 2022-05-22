using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV_TC
{
    public partial class Xrpt_InBDHM : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_InBDHM()
        {
            InitializeComponent();
        }
        public Xrpt_InBDHM(String nienKhoa, String hocKy, String maMon, String nhom)
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
