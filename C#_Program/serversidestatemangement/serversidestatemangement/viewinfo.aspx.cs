using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace serversidestatemangement
{
    public partial class viewinfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string us = Session["username"].ToString();
            string em = Session["email"].ToString();
            int cn = Convert.ToInt32(Session["usercounter"].ToString());
            cn = cn + 1;
            Session["username"] = cn;
            Label1.Text = us;
            Label2.Text = em;
            Label3.Text = cn.ToString();
        }
    }
}