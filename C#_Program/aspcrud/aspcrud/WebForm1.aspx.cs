using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace aspcrud
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con=new SqlConnection("server=INBOOK_X1\\TEW_SQLEXPRESS;integrated security=true;database=Haldirams");
        DataSet ds = new DataSet();
        SqlDataAdapter dr;
        string str = null;

        public void loaddata()
        {
            str = "select * from customers";
            dr= new SqlDataAdapter(str,con);
            dr.Fill(ds, "customers");
            GridView1.DataSource = ds.Tables["customers"].DefaultView;
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            str = "insert into customers values(@customer_id,@first_name,@last_name,@phone,@email,@city,@state,@zip_code)";
            SqlCommand cmd = new SqlCommand(str,con);
            cmd.Parameters.AddWithValue("@customer_id",Convert.ToInt32(TextBox2.Text));
            cmd.Parameters.AddWithValue("@first_name",Convert.ToString(TextBox5.Text));
            cmd.Parameters.AddWithValue("@last_name", Convert.ToString(TextBox3.Text));
            cmd.Parameters.AddWithValue("@phone",Convert.ToInt32(TextBox4.Text));
            cmd.Parameters.AddWithValue("@email",TextBox6.Text);
            cmd.Parameters.AddWithValue("@city", TextBox7.Text);
            cmd.Parameters.AddWithValue("@state", TextBox8.Text);
            cmd.Parameters.AddWithValue("@zip_code",Convert.ToInt32(TextBox9.Text));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record saved";
            TextBox2.Text = "";
            TextBox2.Focus();
            loaddata();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            str = "update  customers set first_name=@first_name,last_name=@last_name,phone=@phone,email=@email,city=@city,state=@state,zip_code=@zip_code where customer_id=@customer_id";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.Parameters.AddWithValue("@first_name", Convert.ToString(TextBox5.Text));
            cmd.Parameters.AddWithValue("@last_name", Convert.ToString(TextBox3.Text));
            cmd.Parameters.AddWithValue("@phone", Convert.ToInt32(TextBox4.Text));
            cmd.Parameters.AddWithValue("@email", TextBox6.Text);
            cmd.Parameters.AddWithValue("@city", TextBox7.Text);
            cmd.Parameters.AddWithValue("@state", TextBox8.Text);
            cmd.Parameters.AddWithValue("@zip_code", Convert.ToInt32(TextBox9.Text));
            cmd.Parameters.AddWithValue("@customer_id", Convert.ToInt32(TextBox2.Text));

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record updated";
            TextBox2.Text = "";
            TextBox2.Focus();
            loaddata();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            str = "delete from customers where first_name=@first_name";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.Parameters.AddWithValue("@first_name", Convert.ToString(TextBox5.Text));
           
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record deleted";
            TextBox2.Text = "";
            TextBox2.Focus();
            loaddata();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            str = "select * from customers where customer_id=@customer_id";
            dr=new SqlDataAdapter(str,con);
            dr.SelectCommand.Parameters.AddWithValue("@customer_id", Convert.ToInt32(TextBox2.Text));
            dr.Fill(ds, "customers");
            TextBox5.Text = ds.Tables["customers"].Rows[0].ItemArray[1].ToString();
            TextBox3.Text = ds.Tables["customers"].Rows[0].ItemArray[2].ToString();
            TextBox4.Text = ds.Tables["customers"].Rows[0].ItemArray[3].ToString();
            TextBox6.Text = ds.Tables["customers"].Rows[0].ItemArray[4].ToString();
            TextBox7.Text = ds.Tables["customers"].Rows[0].ItemArray[5].ToString();
            TextBox8.Text = ds.Tables["customers"].Rows[0].ItemArray[6].ToString();
            TextBox9.Text = ds.Tables["customers"].Rows[0].ItemArray[7].ToString();
            GridView1.DataSource= ds.Tables["customers"].DefaultView;
            GridView1.DataBind();
        }
    }
}