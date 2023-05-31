using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace databaseconnection
{
    public static class DatabaseConnectioncs
    {
        private static string connectionString = "server=INBOOK_X1\\TEW_SQLEXPRESS; integrated security=true;database=civica;";
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                return conn;
            }
            catch (SqlException ex)
            {
                return null;
            }
        }
    }
}
