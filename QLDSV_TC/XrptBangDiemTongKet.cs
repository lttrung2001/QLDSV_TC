using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV_TC
{
    public partial class XrptBangDiemTongKet : DevExpress.XtraReports.UI.XtraReport
    {
        public XrptBangDiemTongKet()
        {
            InitializeComponent();
        }
        public XrptBangDiemTongKet(String maLop)
        {
            InitializeComponent();
            sqlDataSource1.Connection.ConnectionString = "XpoProvider=MSSqlServer;" + Program.connectionString;
            sqlDataSource1.Queries[0].Parameters[0].Value = maLop;
            sqlDataSource1.Fill();
        }
    }
}
