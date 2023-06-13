using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection.Emit;


namespace AspTrustProject1
{
    public partial class WebForm3 : System.Web.UI.Page
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
            str = "insert into Department_MAster values(@Department_Name)";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.Parameters.AddWithValue("@Department_Name", TextBox1.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record inserted";
            TextBox1.Text = ""; ;
            TextBox1.Focus();
            // loaddata();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            str = "update Department_MAster set department_name=@Department_Name";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.Parameters.AddWithValue("@Department_Name", TextBox1.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record updated";
            TextBox1.Text = "";
            TextBox1.Focus();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            str = "delete from Department_Master where Department_Name=@Department_Name";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.Parameters.AddWithValue("@Department_Name", TextBox1.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record deleted";
            TextBox1.Text = "";
            TextBox1.Focus();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            str = "select * from department_Master where department_id=@department_id";
            dr = new SqlDataAdapter(str, con);
            dr.SelectCommand.Parameters.AddWithValue("@Department_id", TextBox2.Text);
            dr.Fill(ds, "department_Master");
            TextBox1.Text = ds.Tables["department_Master"].Rows[0].ItemArray[1].ToString();

        }
    }
}