using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDSV_TC
{
    internal class SQL
    {
        public SqlConnection MoKetNoi(String ds, String loginName, String password)
        {
            string connectionString = @String.Format("Data Source={0};" +
                                                        "Initial Catalog=QLDSV_TC;" +
                                                        "User ID={1};" +
                                                        "Password={2}",
                                                        ds, loginName, password);
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();
            return cnn;
        }
    }
}
