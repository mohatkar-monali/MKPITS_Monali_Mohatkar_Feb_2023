using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Studentinformationado
{
    //creating static class 
    public static class StudentData
    {
        //creating static variable
        private static string connect = "server=INBOOK_X1\\TEW_SQLEXPRESS;integrated security=true;database=civica;";
        //creating static method
        public static SqlConnection GetstdData()
        {
            SqlConnection conn = new SqlConnection(connect);
            try
            {
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        //creating static method to insert record
        public static string GetstudentData(string fname,string lname,string rollno,string course,string mobno) 
        {
            SqlConnection conn = GetstdData();
            string query = "insert into student values(@fname,@lname,@rollno,@course,@mobno)";
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@fname",fname);
                cmd.Parameters.AddWithValue("@lname", lname);
                cmd.Parameters.AddWithValue("@rollno", rollno);
                cmd.Parameters.AddWithValue("@course", course);
                cmd.Parameters.AddWithValue("@mobno", mobno);
               
                cmd.ExecuteNonQuery();
                return "record inserted successfully";
            }
            catch (Exception ex)
            {
                return ex.ToString();   
            }
            finally { conn.Close(); }
        }
    }
}
