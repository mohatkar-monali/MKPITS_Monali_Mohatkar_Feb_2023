using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace registerwithcookie
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["cook"];
            if (cookie != null)
            {
                string name = cookie.Values["name"].ToString();
                string email= cookie.Values["email"].ToString();
                int mobno = Convert.ToInt32(cookie.Values["mobno"]);
                Label2.Text = name;
                Label3.Text = email;
                Label4.Text = mobno.ToString();
            }
            else
            {
                Label2.Text = "No cookie";
            }
        }
    }
}