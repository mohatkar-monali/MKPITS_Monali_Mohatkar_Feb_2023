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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            string res = Item.InsertItemMaster(TextBox1.Text,DropDownList1.SelectedValue,Convert.ToInt32(TextBox2.Text),Convert.ToInt32(TextBox3.Text));
            Label1.Text = res;
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            string res = Item.UpdateItemMaster(TextBox1.Text,Convert.ToInt32( TextBox2.Text));
            Label1.Text = res;
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            string res =Storelibrary.Item.DeleteItemMaster(TextBox1.Text);
            Label1.Text = res;
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds= Item.SearchItemMaster(TextBox1.Text);
            if (ds.Tables["item_master"].Rows.Count != 0)
            {
                //TextBox2.Text = ds.Tables["item_master"].Rows[0].ItemArray[1].ToString();
                TextBox1.Text = ds.Tables["Item_Master"].Rows[0].ItemArray[1].ToString();
                TextBox2.Text = ds.Tables["Item_Master"].Rows[0].ItemArray[2].ToString();
                TextBox3.Text = ds.Tables["Item_Master"].Rows[0].ItemArray[3].ToString();
            }
            else
            {
                Label1.Text = "no record exists on item table";
            }

        }
    }
}