using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspcounntrycity
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList2.Items.Clear();
            switch(DropDownList1.Text)
            {
                case "India":
                    DropDownList2.Items.Add("Nagpur");
                    DropDownList2.Items.Add("Mumbai");
                    break;
                case "USA":
                    DropDownList2.Items.Add("LA");
                    DropDownList2.Items.Add("New York");
                    break;
                case "Japan":
                    DropDownList2.Items.Add("Tokeyo");
                    DropDownList2.Items.Add("Kobe");
                    break;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
        
        }
    }
}