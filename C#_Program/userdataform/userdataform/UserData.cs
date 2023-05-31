using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace userdataform
{
    public static class UserData
    {
        private static string conncetion = "server=INBOOK_X1\\TEW_SQLEXPRESS;integrated security=true;database=civica;";
        public static SqlConnection GetConnection()
        {
            SqlConnection con=new SqlConnection(conncetion);
            try
            {
                con.Open();
                return con;

            }
            catch(Exception ex)
            {
                return null;
            }
        }
        public static string InsertUser(string username,string password)
        {
            SqlConnection conn = GetConnection();
            string query = "insert into users values(@username,@password)";
            try
            {
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.ExecuteNonQuery();
                return "record inserted";
            }
            catch(Exception ex) 
            {
                return ex.ToString();
            } 
            finally { conn.Close(); }
        }

    }
}
