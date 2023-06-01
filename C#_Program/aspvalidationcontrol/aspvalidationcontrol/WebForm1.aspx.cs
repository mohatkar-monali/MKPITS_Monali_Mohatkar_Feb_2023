using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspvalidationcontrol
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("First Name" + TextBox1.Text + "<br>");
            sb.Append("Password" + TextBox2.Text + "<br>");
            sb.Append("Age" + TextBox4.Text + "<br>");
            sb.Append("Email Id" + TextBox5.Text + "<br>");
            Label1.Text = sb.ToString();
        }
    }
}