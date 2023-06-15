using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Storelibrary
{
    public static class Vendorclas
    {
        static SqlConnection con = Dbconncetion.GetConnection();
        static string query = null;
        static  SqlCommand cmd=null;
        //method to insert record into vendor master
        public static string InsertVendorMaster(string vendor_Name)
        {
            string res = null;
            try
            {
                query = "insert into vendor_master values(@vendor_name)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@vendor_Name", vendor_Name);
                con.Open();
                cmd.ExecuteNonQuery();
                res = "record inserted successfully";
            }
            catch (Exception ex)
            {
                res = ex.ToString();
            }
            finally { con.Close(); }
            return res;

        }
        //method to update record into vendor master
        public static string UpdateVendorMaster(string vendor_name,int vendor_id)
        {
            string res = null;
            //code to check whether the vendorid exist or not
            query = "select count(*) from vendor_master where vendor_id=@vendor_id";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@vendor_id",vendor_id);
          //  con.Open();
            int cnt=Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            if (cnt > 0)
            {
                try
                {
                    query = "update vendor_master set vendor_name=@vendor_name where vendor_id=@vendor_id";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@vendor_name", vendor_name);
                    cmd.Parameters.AddWithValue("@vendor_id", vendor_id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    res = "record updated successfully";
                }
                catch (Exception ex)
                {
                    res = ex.ToString();
                }
                finally { con.Close(); }
             
            }
            else
            {
                res = "no record exist";
            }
            return res;
        }
        //code to delete record from vendor master
        public static string DeletevendorMaster(int vendor_id)
        {
            string res = null;
            //code to check whether the vendorid exist or not
            query = "select count(*) from vendor_master where vendor_id=@vendor_id";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@vendor_id", vendor_id);
            //  con.Open();
            int cnt = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            if (cnt > 0)
            {
                try
                {
                    query = "delete from vendor_master where vendor_id=@vendor_id";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@vendor_id", vendor_id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    res = "record deleted successfully";
                }
                catch (Exception ee)
                {
                    res = ee.ToString();
                }
                finally
                {
                    con.Close();
                }
                return res;
            }
            else
            {
                res = "no record exist";
            }
            return res;
        }
        //code to search record from vendor master
        public static string SearchVendorMaster(int vendor_id)
        {
            string res = null;
            query = "select * from vendor_master where vendor_id=@vendor_id";
            DataSet ds =new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@vendor_id", vendor_id);
            da.Fill(ds,"vendor_master");
            return res;
        }
    }
}
