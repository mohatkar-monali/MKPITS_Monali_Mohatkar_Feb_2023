using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace AspTrustProject1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection con=new SqlConnection("server=INBOOK_X1\\TEW_SQLEXPRESS;integrated security=true;database=TRUST;");
        DataSet ds = new DataSet();
        SqlDataAdapter dr;
        string str = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
         public void loaddata()
        {
            str = "select*from Item_Master";
            dr= new SqlDataAdapter(str,con);
            dr.Fill(ds, "Item_Master");
            GridView1.DataSource= ds.Tables["Item_Master"].DefaultView;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            str = "insert into Item_Master values(@Item_Name,@Category,@rate,@balance_quantity)";
            SqlCommand cmd =new SqlCommand(str,con);
            cmd.Parameters.AddWithValue("@Item_Name",TextBox1.Text);
            cmd.Parameters.AddWithValue("@Category", DropDownList1.Text);
            cmd.Parameters.AddWithValue("@rate", TextBox2.Text);
            cmd.Parameters.AddWithValue("@balance_quantity", TextBox3.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record inserted";
            TextBox1.Text = ""; ;
            TextBox1.Focus();
            loaddata();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            str = "update Item_Master set Item_Name=@Item_Name where category=@category";
            SqlCommand cmd =new SqlCommand(str,con);
            cmd.Parameters.AddWithValue("@Item_Name", TextBox1.Text);
            cmd.Parameters.AddWithValue("@rate", TextBox2.Text);
            cmd.Parameters.AddWithValue("@balance_quantity", TextBox3.Text);
            cmd.Parameters.AddWithValue("@Category", DropDownList1.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record updated";
            TextBox1.Text = ""; ;
            TextBox1.Focus();
            loaddata();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            str = "delete from Item_Master where Item_Name=@Item_Name";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.Parameters.AddWithValue("@Item_Name", TextBox1.Text);
         
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record deleted";
            TextBox1.Text = ""; ;
            TextBox1.Focus();
            loaddata();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            str = "select * from Item_Master where Item_Name=@Item_Name";
            dr=new SqlDataAdapter(str,con);
            dr.SelectCommand.Parameters.AddWithValue("Item_Name", TextBox1.Text);
            dr.Fill(ds, "Item_Master");
            TextBox1.Text = ds.Tables["Item_Master"].Rows[0].ItemArray[1].ToString();
            TextBox2.Text = ds.Tables["Item_Master"].Rows[0].ItemArray[2].ToString();
            TextBox3.Text = ds.Tables["Item_Master"].Rows[0].ItemArray[3].ToString();
            GridView1.DataSource = ds.Tables["Item_Master"].DefaultView ;
            GridView1.DataBind();
        }
    }
}