using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Messhosoppingsite
{
    public partial class _Default : Page
    {
        SqlConnection con=new SqlConnection("server=INBOOK_X1\\TEW_SQLEXPRESS;integrated security=true;database=shopsydb");
        SqlDataAdapter adapter;
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da=new SqlDataAdapter("select * from products",con);
            DataSet ds=new DataSet();
            da.Fill(ds,"products");
            DataList1.DataSource= ds.Tables["products"].DefaultView;
            DataList1.DataBind();
        }
    }
}