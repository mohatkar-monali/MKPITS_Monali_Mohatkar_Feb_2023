using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Reflection.Emit;

namespace Messhosoppingsite
{
    public partial class checkmno : System.Web.UI.Page
    {
        string prodid;
        SqlConnection con = new SqlConnection("server=INBOOK_X1\\TEW_SQLEXPRESS;integrated security=true;database=shopsydb");
        SqlCommand command = new SqlCommand();
        string query;
        protected void Page_Load(object sender, EventArgs e)
        {
            prodid = Convert.ToString(Session["productid"]);
            Response.Write("productid " + prodid);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string res = TextBox1.Text;
            string prodname = null;
            int prodprice = 0;
            int qty = 0;
            string sessionid = null;
            if (res == "123456")
            {
                query = "select * from products where productid=@productid";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@productid", prodid);
                con.Open();
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    prodname = dr["productname"].ToString();
                    prodprice = Convert.ToInt32(dr["productprice"].ToString());
                    qty = 1;
                    sessionid = Session.SessionID;

                }
                con.Close();
                Response.Write("productname " + prodname + "<br>");
                Response.Write("productprice " + prodprice + "<br>");
                Response.Write("quantity " + qty + "<br>");
                Response.Write("sessionid " + sessionid + "<br>");
                //save the product data into carttable



                // Response.Redirect("cart1.aspx");22
            }
            else
            {
                Label1.Text = "invalid otp";
            }
        }
    }
    }
