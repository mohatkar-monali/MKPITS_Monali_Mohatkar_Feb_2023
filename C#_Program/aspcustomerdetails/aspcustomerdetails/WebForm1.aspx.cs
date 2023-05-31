using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspcustomerdetails
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int rate, quantity,totalamount;
            rate = Convert.ToInt32(TextBox3.Text);
            quantity = Convert.ToInt32(TextBox4.Text);
            if(RadioButton1.Checked)
            {
                totalamount = rate * quantity;
                Label1.Text = totalamount.ToString();
            }
            else
            {
                totalamount = rate * quantity;
                int emi = totalamount / 3;
                Label1.Text = emi.ToString();
            }
        }
    }
}