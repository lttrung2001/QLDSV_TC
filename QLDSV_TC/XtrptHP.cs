using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV_TC
{
    public partial class XtrptHP : DevExpress.XtraReports.UI.XtraReport
    {
        public XtrptHP()
        {
            InitializeComponent();
        }
        public XtrptHP(String malop,String nienKhoa, String hocKy)
        {
            InitializeComponent();
            sqlDataSource1.Connection.ConnectionString = "XpoProvider=MSSqlServer;" + Program.connectionString;
            sqlDataSource1.Queries[0].Parameters[0].Value = malop;
            sqlDataSource1.Queries[0].Parameters[1].Value = nienKhoa;
            sqlDataSource1.Queries[0].Parameters[2].Value = int.Parse(hocKy);
            sqlDataSource1.Fill();
        }
    }
}
