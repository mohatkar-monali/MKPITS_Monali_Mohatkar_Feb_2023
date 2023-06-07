using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace temporarycookie
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //code to create temporary cookie
            HttpCookie cookie = new HttpCookie("cook");
            cookie.Values.Add("name", TextBox1.Text);
            cookie.Values.Add("email", TextBox2.Text);
            Response.Cookies.Add(cookie);
            Label1.Text = "temporary cookie added to client machine";
       
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //code to  retrieve code from client machine
            HttpCookie cookie = Request.Cookies["cook"];
            if(cookie != null)
            {
                string name = cookie.Values["name"].ToString();
                string email = cookie.Values["email"].ToString();
                Label1.Text = "Name:"+name;
                Label2.Text = "Email:"+email;
            }
            else
            {
                Label1.Text = "No cookie added";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //code to create permanant cookie
            HttpCookie cookie1 = new HttpCookie("cook1");
            cookie1.Values.Add("name", TextBox1.Text);
            cookie1.Values.Add ("email", TextBox2.Text);
            DateTime dt=DateTime.Now;
            TimeSpan ts=new TimeSpan(0,1,0);
            cookie1.Expires = dt.Add(ts);
            Response.Cookies.Add(cookie1);
            Label1.Text = "Permanant cookie added";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            //code to retreive permanant cookie
            HttpCookie cookie = Request.Cookies["cook1"];
            if(cookie != null)
            {
                string name = cookie.Values["name"].ToString();
                string email = cookie.Values["email"].ToString();
                Label1.Text = "Name:" + name;
                Label2.Text = "Email:" + email;
            }
            else
            {
                Label1.Text = "No cookie added";
            }
        }
    }
}