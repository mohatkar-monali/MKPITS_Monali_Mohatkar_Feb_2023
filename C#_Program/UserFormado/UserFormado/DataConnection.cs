using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace UserFormado
{
    //creating a static class
    public static class DataConnection
    {
        //creating a static variable
        private static string conncetion = "server=INBOOK_X1\\TEW_SQLEXPRESS;database=civica; integrated security=true;";
       
        //creating a static method
        public static SqlConnection GetConnection()
        {
            //creating conncetion
            SqlConnection con = new SqlConnection(conncetion);
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
        //creating a static method to insert record into user table
        public static string InsertRecord(string username,string password)
        {
            SqlConnection con = GetConnection();
            //creating insert command
            string query = "insert into userdata values(@username,@password)";
            //@ username aned @password are sqlcommand
            try
            {
                //creating object of sqlcommand
                SqlCommand command = new SqlCommand(query,con);
                //defining sql parameter
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.ExecuteNonQuery();
                return "record inserted successfully";
            }
            catch(Exception ex)
            {
                return ex.ToString();
            }
            finally
            {
                con.Close();
            }
        }
    }
}
