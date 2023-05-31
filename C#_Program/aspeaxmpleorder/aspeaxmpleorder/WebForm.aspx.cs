using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspeaxmpleorder
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int totalamount = 0;
            int price = Convert.ToInt32(TextBox2.Text);
            int quantity=Convert.ToInt32(TextBox3.Text);
            totalamount = price* quantity;  
            Label1.Text = totalamount.ToString();
        }
    }
}