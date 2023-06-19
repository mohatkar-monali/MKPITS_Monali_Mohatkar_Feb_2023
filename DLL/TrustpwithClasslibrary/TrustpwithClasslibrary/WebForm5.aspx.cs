using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Storelibrary;
using System.Data;

namespace TrustpwithClasslibrary
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Label3.Visible = true;
                DropDownList2.Visible = true;
                Label4.Visible = false;
                DropDownList3.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(RadioButton1.Checked)
            {
                string res = Transaction.TransactionIssue(Convert.ToInt32(DropDownList1.SelectedValue), Convert.ToDateTime(TextBox1.Text),Convert.ToInt32( DropDownList2.SelectedValue),Convert.ToInt32(TextBox2.Text));
                Label2.Text= "inserted into transaction";
            }
            else if (RadioButton2.Checked)
            {
                string res = Transaction.TransactionPurcahse(Convert.ToInt32(DropDownList1.SelectedValue), Convert.ToDateTime(TextBox1.Text), Convert.ToInt32(DropDownList3.SelectedValue), Convert.ToInt32(TextBox2.Text));
                Label2.Text = "inserted into transaction";
            }
            
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Label3.Visible = true;
            DropDownList2.Visible = true;
            Label4.Visible = false;
            DropDownList3.Visible = false;
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Label3.Visible = false;
            DropDownList2.Visible =false;
            Label4.Visible = true;
            DropDownList3.Visible = true;
        }
    }
}