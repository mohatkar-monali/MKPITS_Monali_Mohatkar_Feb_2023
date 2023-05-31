using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Instituteproject
{
    public static class CourseRgistration
    {
        private static string connection = "server=INBOOK_X1\\TEW_SQLEXPRESS;integrated security=true;database=Institute1;";
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(connection);
            try
            {
                //con.Open();
                return con;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static DataSet GetNation()
        {
            SqlConnection con = GetConnection();
            string query = "select * from TableNation";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(ds, "TableNation");
            return ds;
        }
        public static DataSet GetStates(string NationName)
        {
            SqlConnection con = GetConnection();
            //string query = "select * from Tablesate where nationid=@nationid";
            string query = "select c.stateid,c.statename from TableState c inner join tablenation n on c.nationid=n.nationid where @nationname=@nationname";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@nationname", NationName);
            da.Fill(ds, "TableState");
            return ds;
        }
        public static DataSet GetCity(string NationName)
        {
            SqlConnection con = GetConnection();
            string query = "select c.cityid,c.cityname from TableCity c inner join TableState s on c.stateid=s.stateid where @nationname=@nationname";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@nationname", NationName);
            da.Fill(ds, "TableCity");
            return ds;
        }
        public static string SaveTableCourseRegDetails(int CategoryInd, string FullName, int Genderind)
        {
            string result = null;
          
            SqlConnection con = GetConnection();
            con.Open();
            string query = "insert into TableCourseRegDetails values(@categoryind,@fullname,@genderid)";
            SqlCommand cmd = new SqlCommand(query, con);

            //cmd.Parameters.AddWithValue("@courseregid", CourseRegId);
            cmd.Parameters.AddWithValue("@categoryind", CategoryInd);
            cmd.Parameters.AddWithValue("@fullname", FullName);
            cmd.Parameters.AddWithValue("@genderid", Genderind);
            cmd.ExecuteNonQuery();
            
            con.Close(); 
            result= "reecord saved in tavlecourseregdetails";
            return result;
        }
        static int courseid = 0;
        public static string SaveTableRegAddress(int NationId,int StateId, int CityId)
        {
            string result = null;

            SqlConnection con = GetConnection();
            con.Open();
            string query = "SELECT top 1  courseregid FROM tablecourseregdetails ORDER BY courseregid DESC";
            SqlCommand cmd = new SqlCommand(query, con); 
            courseid = Convert.ToInt32(cmd.ExecuteScalar());
            query = "insert into tableregaddress values(@courseregid,@nationid,@stateid,@cityid)";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@courseregid", courseid);
            cmd.Parameters.AddWithValue("@nationid", NationId);
            cmd.Parameters.AddWithValue("@stateid", StateId);
            cmd.Parameters.AddWithValue("@cityid", CityId);
            cmd.ExecuteNonQuery();

            con.Close();
            result = "reecord saved in tableregaddress";
            return result;
        }
        public static string SaveTableFeeDetail(double totalamount, double minper, double paidamount, double balamount, DateTime paiddate)
        {
            //string result = null;
            SqlConnection con = GetConnection();
            con.Open();
            string query = "insert into tablefeedetail values(@courseregid,@totalamount,@minper,@paidamount,@balamount,@paiddate)";
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@courseregid", courseid);
            command.Parameters.AddWithValue("@totalamount", totalamount);
            command.Parameters.AddWithValue("@minper", minper);
            command.Parameters.AddWithValue("@paidamount", paidamount);
            command.Parameters.AddWithValue("@balamount", balamount);
            command.Parameters.AddWithValue("@paiddate", paiddate);
            command.ExecuteNonQuery();
            con.Close();
            return "record saved in tablefeedetail";
            //return result;
        }
    }
}

