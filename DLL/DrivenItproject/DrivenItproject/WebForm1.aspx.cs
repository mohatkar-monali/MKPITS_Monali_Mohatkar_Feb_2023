using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace DrivenItproject
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con=new SqlConnection("server=INBOOK_X1\\TEW_SQLEXPRESS;integrated security=true;database=drivenitdb");
        SqlCommand cmd;
        string query = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                query = "insert into transactions values(@itemid,@transtype,@transqty,@transedate)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@itemid", DropDownList1.SelectedValue);
                string traanst = null;
                if(RadioButton1.Checked)
                {
                    traanst = "I";
                }
                else if(RadioButton2.Checked)
                {
                    traanst = "R";
                }
                cmd.Parameters.AddWithValue("@transtype", traanst);
                cmd.Parameters.AddWithValue("@transqty", TextBox2.Text);
                cmd.Parameters.AddWithValue("@transedate", TextBox1.Text);
                con.Open();
                cmd.ExecuteNonQuery();

                //geting quantity from item master for perticular item id
                query = "select max(balqty) from itemmaster where itemid=@itemid";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@itemid", DropDownList1.SelectedValue);
                int bq = Convert.ToInt32(cmd.ExecuteScalar());
                if (traanst == "I")
                {
                    bq = bq - Convert.ToInt32(TextBox2.Text);
                }
                else if (traanst == "R")
                {
                    bq = bq + Convert.ToInt32(TextBox2.Text);
                }

                //updating baalqty on item mmaster
                query = "update itemmaster set balqty=@balqty where itemid=@itemid";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@balqty", bq);
                cmd.Parameters.AddWithValue("itemid", DropDownList1.Text);
                cmd.ExecuteNonQuery();
                Label1.Text = "record saved";

            }
            catch (Exception ex)
            {
                Label1.Text = ex.ToString();
            }
            finally { con.Close(); }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                query = "update transactions set transtype=@transtype,transqty=@transqty,transedate=@transedate where itemid=@itemid";
                SqlCommand cmd = new SqlCommand(query, con);
            
                string traanst = null;
                if (RadioButton1.Checked)
                {
                    traanst = "I";
                }
                else if (RadioButton2.Checked)
                {
                    traanst = "R";
                }
                cmd.Parameters.AddWithValue("@transtype", traanst);
                cmd.Parameters.AddWithValue("@transqty", TextBox2.Text);
                cmd.Parameters.AddWithValue("@transedate", TextBox1.Text);
                cmd.Parameters.AddWithValue("@itemid", DropDownList1.SelectedValue);
                con.Open();
                cmd.ExecuteNonQuery();

                //geting quantity from item master for perticular item id
                query = "select max(balqty) from itemmaster where itemid=@itemid";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@itemid", DropDownList1.SelectedValue);
                int bq = Convert.ToInt32(cmd.ExecuteScalar());
                if (traanst == "I")
                {
                    bq = bq - Convert.ToInt32(TextBox2.Text);
                }
                else if (traanst == "R")
                {
                    bq = bq + Convert.ToInt32(TextBox2.Text);
                }

                //updating baalqty on item mmaster
                query = "update itemmaster set balqty=@balqty where itemid=@itemid";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@balqty", bq);
                cmd.Parameters.AddWithValue("itemid", DropDownList1.Text);
                cmd.ExecuteNonQuery();
                Label1.Text = "record updated";

            }
            catch (Exception ex)
            {
                Label1.Text = ex.ToString();
            }
            finally { con.Close(); }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox2.Text = GridView1.SelectedRow.Cells[4].Text;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                query = "delete from transactions  where itemid=@itemid";
                SqlCommand cmd = new SqlCommand(query, con);

         
                cmd.Parameters.AddWithValue("@itemid", DropDownList1.SelectedValue);
                con.Open();
                cmd.ExecuteNonQuery();

               
                Label1.Text = "record deleted";

            }
            catch (Exception ex)
            {
                Label1.Text = ex.ToString();
            }
            finally { con.Close(); }
        }

    }
}
