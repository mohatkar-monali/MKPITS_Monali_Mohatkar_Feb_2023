using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DrivenItproject
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=INBOOK_X1\\TEW_SQLEXPRESS;integrated security=true;database=drivenitdb");
        SqlCommand cmd;
        string query = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
       
            try
            {
                query = "insert into itemmaster values(@itemdesc,@balqty,@createon)";
                cmd = new SqlCommand(query, con);
               // cmd.Parameters.AddWithValue("@itemid", TextBox4.Text);
                cmd.Parameters.AddWithValue("@itemdesc", TextBox1.Text);
                cmd.Parameters.AddWithValue("balqty", TextBox2.Text);
                cmd.Parameters.AddWithValue("createon", TextBox3.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                Label1.Text = "record saved";
            }
            catch (Exception ex)
            {
                Label1.Text=ex.ToString();
            }
            finally { con.Close(); }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                query = "update itemmaster set balqty=@balqty where itemid=@itemid";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("balqty", TextBox2.Text);
                cmd.Parameters.AddWithValue("itemid", TextBox4.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                Label1.Text = "record updated";
            }
            catch (Exception ex)
            {
                Label1.Text = ex.ToString();
            }
            finally { con.Close(); }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                query = "delete from itemmaster where itemid=@itemid";
                cmd = new SqlCommand(query, con);
               // cmd.Parameters.AddWithValue("balqty", TextBox2.Text);
                cmd.Parameters.AddWithValue("itemid", TextBox4.Text);
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