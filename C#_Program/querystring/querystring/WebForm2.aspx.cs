using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace querystring
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name,email;
            name = Request.QueryString["name"].ToString();
            email = Request.QueryString["email"].ToString();
            Response.Write("Name:" + name);
            Response.Write("email:" + email);
            //Label1.Text = name;
        }
    }
}