using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspTrustProject1
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (RadioButton1.Checked)
            {
                Panel2.Visible = true;
                Label2.Visible = false;
                DropDownList4.Visible = false;
            }
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton1.Checked)
            {

                Panel2.Visible = true;
                Label2.Visible = false;
                DropDownList4.Visible = false;
            }
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton2.Checked)
            {

                Label2.Visible = true;
                DropDownList4.Visible = true;
                Panel2.Visible = false;
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            string query = null;
            SqlConnection con=new SqlConnection("server=INBOOK_X1\\TEW_SQLEXPRESS;integrated security=true;database=trust;");
            SqlCommand command;
            if (RadioButton1.Checked)
            {
                try
                {
                    query = "insert into Transaction_Details(item_id,transactiondate,department_id,quantity)values(@item_id,@transactiondate,@department_id,@quantity)";
                    command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@item_id", DropDownList3.SelectedValue);
                    command.Parameters.AddWithValue("@transactiondate", TextBox1.Text);
                    command.Parameters.AddWithValue("@department_id", DropDownList2.SelectedValue);
                    command.Parameters.AddWithValue("@quantity", TextBox2.Text);
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();

                    //code to get balance quantity from itemmaster
                    int bal_quntity = 0;
                    query = "select balance_quantity from item_master where item_id=@item_id";
                    command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@item_id", DropDownList3.SelectedValue);
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        bal_quntity = Convert.ToInt32(reader[0].ToString());
                    }
                    reader.Close();
                    con.Close();
                    //Response.Write("balance quantity is"+bal_quntity.ToString());
                    int qty = bal_quntity - Convert.ToInt32(TextBox2.Text);

                    query = "update item_master set balance_quantity=@balance_quantity where item_id=@item_id";
                    command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@balance_quantity", qty);
                    command.Parameters.AddWithValue("@item_id", DropDownList3.SelectedValue);
                    con.Open();
                    command.ExecuteNonQuery();
                    Label1.Text = "item issues to department successfully";
                }

                catch (Exception ee)
                {
                    Label1.Text = ee.ToString();
                }
                finally { con.Close(); }
            }
               
                if (RadioButton2.Checked)
                {
                    try
                    {
 
                        query = "insert into Transaction_Details(item_id,transactiondate,vendor_id,quantity)values(@item_id,@transactiondate,@vendor_id,@quantity)";
                        command = new SqlCommand(query, con);
                        command.Parameters.AddWithValue("@item_id", DropDownList3.SelectedValue);
                        command.Parameters.AddWithValue("@transactiondate", TextBox1.Text);
                        command.Parameters.AddWithValue("@vendor_id", DropDownList4.SelectedValue);
                        command.Parameters.AddWithValue("@quantity", TextBox2.Text);
                        con.Open();
                        command.ExecuteNonQuery();
                        con.Close();

                        //code to get balance quantity from itemmaster
                        int bal_quntity = 0;
                        query = "select balance_quantity from item_master where item_id=@item_id";
                        command = new SqlCommand(query, con);
                        command.Parameters.AddWithValue("@item_id", DropDownList3.SelectedValue);
                        con.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            bal_quntity = Convert.ToInt32(reader[0].ToString());
                        }
                        reader.Close();
                        con.Close();
                        //Response.Write("balance quantity is"+bal_quntity.ToString());
                        int qty = bal_quntity + Convert.ToInt32(TextBox2.Text);

                        query = "update item_master set balance_quantity=@balance_quantity where item_id=@item_id";
                        command = new SqlCommand(query, con);
                        command.Parameters.AddWithValue("@balance_quantity", qty);
                        command.Parameters.AddWithValue("@item_id", DropDownList3.SelectedValue);
                        con.Open();
                        command.ExecuteNonQuery();
                        Label1.Text = "item purchase to vendor successfully";
                    }
                
                     catch(Exception ee) 
                    {
                         Label1.Text = ee.ToString();
                    }
                     finally { con.Close(); }
                }
        }

        protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}