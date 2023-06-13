using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspTrustProject1
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=INBOOK_X1\\TEW_SQLEXPRESS;integrated security=true;database=TRUST;");
        DataSet ds = new DataSet();
        SqlDataAdapter dr;
        string str = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            str = "insert into vendor_MAster values(@vendor_Name)";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.Parameters.AddWithValue("@vendor_Name", TextBox2.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record inserted";
            TextBox2.Text = ""; ;
            TextBox2.Focus();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            str = "update vendor_MAster set vendor_name=@vendor_Name";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.Parameters.AddWithValue("@vendor_Name", TextBox2.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record updated";
            TextBox2.Text = "";
            TextBox2.Focus();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            str = "delete from  vendor_Master where vendor_Name=@vendor_Name";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.Parameters.AddWithValue("@vendor_Name", TextBox2.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record deleted";
            TextBox2.Text = "";
            TextBox2.Focus();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            str = "select * from vendor_Master where vendor_id=@vendor_id";
            dr = new SqlDataAdapter(str, con);
            dr.SelectCommand.Parameters.AddWithValue("@vendor_id", TextBox3.Text);
            dr.Fill(ds, "vendor_Master");
            TextBox2.Text = ds.Tables["vendor_Master"].Rows[0].ItemArray[1].ToString();

        }
    }
}