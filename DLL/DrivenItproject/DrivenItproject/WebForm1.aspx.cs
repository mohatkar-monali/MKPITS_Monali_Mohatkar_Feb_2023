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
        static int transid = 0;
        static int oldtransqty = 0;
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Write("transaction id is" + transid);
            int updatedqty = 0;
            updatedqty=Convert.ToInt32(TextBox2.Text)-oldtransqty;
            Response.Write("updated quantity is"+updatedqty);
            try
            {
                query = "update transactions set itemid=@itemid,transtype=@transtype,transqty=@transqty,transedate=@transedate where transid=@transid";
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
                cmd.Parameters.AddWithValue("@itemid", DropDownList1.SelectedValue);
                cmd.Parameters.AddWithValue("@transtype", traanst);
                cmd.Parameters.AddWithValue("@transqty", TextBox2.Text);
                cmd.Parameters.AddWithValue("@transedate", TextBox1.Text);
                cmd.Parameters.AddWithValue("@transid", transid);
                con.Open();
                cmd.ExecuteNonQuery();

                //geting quantity from item master for perticular item id
                query = "select max(balqty) from itemmaster where itemid=@itemid";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@itemid", DropDownList1.SelectedValue);
                int bq = Convert.ToInt32(cmd.ExecuteScalar());
                Response.Write("bq" + bq.ToString());
                Response.Write("updatedqty" + updatedqty.ToString());
                if (RadioButton1.Checked)
                {
                    bq = bq - updatedqty;
                }
                if (RadioButton2.Checked)
                {
                    bq = bq + updatedqty;
                }
                Response.Write("newupdatedqty is " + bq.ToString());
                if (bq < 0)
                {
                    Label1.Text = "stock not available";
                }
                else
                {
                    //updating baalqty on item mmaster
                    query = "update itemmaster set balqty=@balqty where itemid=@itemid";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@balqty", bq);
                    cmd.Parameters.AddWithValue("itemid", DropDownList1.Text);
                    cmd.ExecuteNonQuery();
                    Label1.Text = "record updated";
                }
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
            oldtransqty=Convert.ToInt32(TextBox2.Text);
            string res= GridView1.SelectedRow.Cells[3].Text;
            if (res=="I")
            {
                RadioButton2.Checked = false;
                RadioButton1.Checked = true;

            }
            else if (res=="R")
            {
                RadioButton1.Checked = false;
                RadioButton2.Checked = true;
            }
            DateTime dt = Convert.ToDateTime(GridView1.SelectedRow.Cells[5].Text);
            TextBox1.Text = dt.ToString("yyyy-MM-dd");
            DropDownList1.SelectedValue = GridView1.SelectedRow.Cells[1].Text;
            transid = Convert.ToInt32(GridView1.SelectedRow.Cells[1].Text) ;
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
