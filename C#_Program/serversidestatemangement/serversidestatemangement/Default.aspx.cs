﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace serversidestatemangement
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cn = (string)Application["companyname"];
            Label1.Text = cn;
            int counter = (int)Application["counter"];
            counter = counter + 1;
            Response.Write("companyname" + cn + "<br>");
            Application["counter"] = counter;
            Label2.Text=" you are visitor No" + counter.ToString() + "<br>";
        }
    }
}