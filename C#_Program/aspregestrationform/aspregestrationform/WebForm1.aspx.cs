using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspregestrationform
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("Name" + TextBox3.Text + "<br>");
            sb.Append("Password" + TextBox4.Text + "<br>");
            sb.Append("Address" + TextBox5.Text + "<br>");
            sb.Append("Mobile Number" + TextBox6.Text + "<br>");
            sb.Append("Date Of Birth" + TextBox7.Text + "<br>");
            if(RadioButton1.Checked) 
            sb.Append("gender" + RadioButton1.Text + "<br>");
            else
                sb.Append("gender" + RadioButton2.Text + "<br>");
            sb.Append("Hobbies" + CheckBox1.Text + "<br>");
            sb.Append("Hobbies" + CheckBox2.Text + "<br>");

            sb.Append("City" + DropDownList1.Text + "<br>");
            Label1.Text = sb.ToString();
        }
    }
}