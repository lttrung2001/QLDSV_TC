using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QLDSV_TC
{
    internal static class Program
    {
        public static frmMain frmChinh;
        public static String tenPhanManh;
        public static String ma;
        public static String hoTen;
        public static String tenNhom;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmChinh = new frmMain();
            Application.Run(frmChinh);
        }
    }
}
