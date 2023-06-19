using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.Emit;
using System.Security.AccessControl;

namespace Storelibrary
{
    public static class Transaction
    {
        static SqlConnection con = Dbconncetion.GetConnection();
        static string query = null;
        static SqlCommand cmd = null;

        public static string TransactionIssue(int item_id, DateTime transactiondate, int department_id, int quantity)
        {
            try
            {
                query = "insert into Transaction_Details(item_id,transactiondate,department_id,quantity)values(@item_id,@transactiondate,@department_id,@quantity)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@item_id",item_id);
                cmd.Parameters.AddWithValue("@transactiondate", transactiondate);
                cmd.Parameters.AddWithValue("@department_id", department_id);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                //code to get balance quantity from itemmaster
                int bal_quntity = 0;
                query = "select balance_quantity from item_master where item_id=@item_id";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@item_id",item_id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    bal_quntity = Convert.ToInt32(reader[0].ToString());
                }
                reader.Close();
                con.Close();
                //Response.Write("balance quantity is"+bal_quntity.ToString());
                int qty = bal_quntity - quantity;

                query = "update item_master set balance_quantity=@balance_quantity where item_id=@item_id";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@balance_quantity", qty);
                cmd.Parameters.AddWithValue("@item_id", item_id);
                con.Open();
                cmd.ExecuteNonQuery();
                return  "item issues to department successfully";
            }

            catch (Exception ee)
            {
               return ee.ToString();
            }
            finally { con.Close(); }
        }
        public static string TransactionPurcahse(int item_id, DateTime transactiondate, int vendor_id, int quantity)
        {

            try
            {

                query = "insert into Transaction_Details(item_id,transactiondate,vendor_id,quantity)values(@item_id,@transactiondate,@vendor_id,@quantity)";
                cmd= new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@item_id", item_id);
                cmd.Parameters.AddWithValue("@transactiondate", transactiondate);
                cmd.Parameters.AddWithValue("@vendor_id", vendor_id);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                //code to get balance quantity from itemmaster
                int bal_quntity = 0;
                query = "select balance_quantity from item_master where item_id=@item_id";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@item_id", item_id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    bal_quntity = Convert.ToInt32(reader[0].ToString());
                }
                reader.Close();
                con.Close();
                //Response.Write("balance quantity is"+bal_quntity.ToString());
                int qty = bal_quntity +quantity;

                query = "update item_master set balance_quantity=@balance_quantity where item_id=@item_id";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@balance_quantity", qty);
                cmd.Parameters.AddWithValue("@item_id", item_id);
                con.Open();
                cmd.ExecuteNonQuery();
                return "item purchase to vendor successfully";
            }

            catch (Exception ee)
            {
                return ee.ToString();
            }
            finally { con.Close(); }
        }
    }
    
}
