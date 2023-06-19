using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Storelibrary
{
    public static class Item
    {
        static SqlConnection con = Dbconncetion.GetConnection();
        static string query = null;
        static SqlCommand cmd = null;

        //method to insert record into item master
        public static string InsertItemMaster(string item_name, string category, int rate, int balance_quantity)
        {
            string res = null;
            try
            {
                query = "insert into item_master values(@item_name,@category,@rate,@balance_quantity)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@item_name", item_name);
                cmd.Parameters.AddWithValue("@category", category);

                cmd.Parameters.AddWithValue("@rate", rate);

                cmd.Parameters.AddWithValue("@balance_quantity", balance_quantity);

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
        //method to update record into item master
        public static string UpdateItemMaster(string Item_name, int rate)
        {
            string res = null;
            ////code to check whether the departmentid exist or not
            //query = "select count(*) from department_master where department_id=@department_id";
            //cmd = new SqlCommand(query, con);
            //cmd.Parameters.AddWithValue("@department_id", department_id);
            //con.Open();
            //int cnt = Convert.ToInt32(cmd.ExecuteScalar());
            //con.Close();
            //if (cnt > 0)
            //{
            try
            {
                query = "update Item_master set Item_name=@Item_name where rate=@rate";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Item_name", Item_name);
                cmd.Parameters.AddWithValue("@rate", rate);
                con.Open();
                cmd.ExecuteNonQuery();
                res = "record updated successfully";
            }
            catch (Exception ex)
            {
                res = ex.ToString();
            }
            finally { con.Close(); }


            // res = "no record exist";

            return res;
        }
        //code to delete record from Item master
        public static string DeleteItemMaster(string Item_Name)
        {
            string res = null;
            ////code to check whether the departmentid exist or not
            //query = "select count(*) from department_master where department_id=@department_id";
            //cmd = new SqlCommand(query, con);
            //cmd.Parameters.AddWithValue("@item_name", Item_Name);
            //con.Open();
            //int cnt = Convert.ToInt32(cmd.ExecuteScalar());
            //con.Close();
            //if (cnt > 0)
            //{
            try
            {
                query = "delete from item_master where Item_name=@Item_name";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Item_name", Item_Name);
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

            //else
            //{
            //    res = "no record exist";
            //}
            // return res;

        }
        public static DataSet SearchItemMaster(string item_name)
        {

            query = "select * from Item_master where item_name=@item_name";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@item_name", item_name);
          

            da.Fill(ds, "item_master");
            return ds;
        }
    }
}
