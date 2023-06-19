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
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                getvendorid();
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            string res = Vendorclas.InsertVendorMaster(TextBox2.Text);
            Label1.Text = res;
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
             string res = Vendorclas.UpdateVendorMaster(TextBox2.Text,Convert.ToInt32(TextBox3.Text));
             Label1.Text = res;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            string res = Vendorclas.DeletevendorMaster(Convert.ToInt32(TextBox3.Text));
            Label1.Text = res;
        }

        public void getvendorid()
        {
            int res =Convert.ToInt32(Vendorclas.getVendorId());
            res = res + 1;
            TextBox3.Text = res.ToString();
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string res = Vendorclas.SearchVendorMaster(Convert.ToInt32(TextBox3.Text));
            if(ds.Tables["vendor_master"].Rows.Count != 0)
            {
                TextBox2.Text = ds.Tables["vendor_master"].Rows[0].ItemArray[1].ToString();
            }
            else
            { 
                Label1.Text = res;
            }
         
        }
    }
}