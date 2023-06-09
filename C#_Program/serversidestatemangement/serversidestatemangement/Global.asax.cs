﻿ using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace serversidestatemangement
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Application["companyname"] = "mkpits";
            Application["counter"] = 0;
        }
        void Session_Start(object sender,EventArgs e)
        {
            Session["usercounter"] = 0;
            Session["username"] = "";
            Session["email"] = "";
        }
    }
}