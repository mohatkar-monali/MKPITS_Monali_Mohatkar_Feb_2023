using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Messhosoppingsite
{
    public partial class productdetails : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=INBOOK_X1\\TEW_SQLEXPRESS;integrated security=true;database=shopsydb");
        SqlDataAdapter adapter;
        DataSet ds;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            string prodid = Request.QueryString["productid"].ToString();
            Response.Write(prodid);

            SqlDataAdapter da = new SqlDataAdapter("select * from products where productid=@productid", con);
            DataSet ds = new DataSet();
            da.SelectCommand.Parameters.AddWithValue("productid", prodid);
            da.Fill(ds, "productdetails");
            DataList1.DataSource = ds.Tables["productdetails"].DefaultView;
            DataList1.DataBind();
        }
    }
}