using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QLDSV_TC
{
    internal static class Program
    {
        public static SqlConnection conn = new SqlConnection();
        public static String connectionString; // Chuỗi kết nối
        public static SqlDataAdapter da;
        public static SqlDataReader myReader;
        // Tên server hiện tại
        public static String servername = ""; 
        public static int index = 0; // Vị trí
        // Tài khoản đăng nhập
        public static String loginName;
        public static String password;
        // Tên database
        public static String database = "QLDSV_TC";
        public static String connStrSiteChu = "Data Source=DESKTOP-4UNL892\\SERVER0;Initial Catalog=QLDSV_TC;Integrated Security=True";
        // Tài khoản remote
        public static String remoteLogin = "HTKN";
        public static String remotePassword = "HTKN";
        // Form main
        public static frmMain frmChinh;
        // Hiển thị bar dưới cùng
        public static String mMaGV; // Mã GV
        public static String mHoten; // Họ tên
        public static String mTenNhom; // Tên nhóm
        // Binding source danh sách phân mảnh
        public static BindingSource bdsDSPM = new BindingSource();

        public static int KetNoi()
        {
            if (conn != null && conn.State == ConnectionState.Open) conn.Close();
            try
            {
                connectionString = "Data Source=" + servername + ";Initial Catalog=" + database + ";User ID=" +
                      loginName + ";password=" + password;
                conn.ConnectionString = connectionString;
                conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }

        public static SqlDataReader ExecSqlDataReader(String cmd, String connectionstring)
        {
            SqlDataReader myreader;

            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = conn;
            sqlcmd.CommandText = cmd;
            sqlcmd.CommandType = CommandType.Text;

            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();
                return myreader;
            }
            catch (SqlException ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataTable ExecSqlQuery(String cmd, String connectionstring)
        {
            DataTable dt1 = new DataTable();
            conn = new SqlConnection(connectionstring);
            if (conn.State == ConnectionState.Closed) conn.Open();
            da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt1);
            return dt1;

        }

        public static int ExecSqlNonQuery(String cmd, String connectionstring)
        {
            conn = new SqlConnection(connectionstring);
            SqlCommand Sqlcmd = new SqlCommand();
            Sqlcmd.Connection = conn;
            Sqlcmd.CommandText = cmd;
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 300;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery(); conn.Close(); return 1;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                return 0;
            }
        }

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
