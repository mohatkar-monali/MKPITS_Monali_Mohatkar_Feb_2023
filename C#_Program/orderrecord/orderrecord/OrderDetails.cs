using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orderrecord
{
    public static  class OrderDetails
    {
        public static string connection = "server=INBOOK_X1\\TEW_SQLEXPRESS;integrated sercute=true;database=civica";
        public static SqlConnection GetConnection()
        {
            SqlConnection con=new SqlConnection(connection);
            try
            {
                con.Open(); 
                return con;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static string InsertOrders(string ordername,DateTime date,int quantity)
        {
            SqlConnection conn = GetConnection();
            string query = "insert into order values(@ordername,@date,@quantity)";
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ordername", ordername);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.ExecuteNonQuery();
                return "record updated";
            }
            catch(Exception ee)
            {
                return null;
            }
            finally { conn.Close(); }
        }
    }
}
