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
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                 getdepartmentid();
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            string res = Storelibrary.Department.InsertDepartmentMaster(TextBox1.Text);
            Label1.Text = res;
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            string res=Department.UpdateDepartmentMaster(TextBox1.Text,Convert.ToInt32(TextBox2.Text));
            Label1.Text = res;
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            string res = Department.DeleteDepartmentMaster(Convert.ToInt32(TextBox2.Text));
            Label1.Text = res;
        }
        public void getdepartmentid()
        {
            int res = Convert.ToInt32(Department.getDepartmentId());
            res = res + 1;
           TextBox2.Text = res.ToString();
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds= Department.SearchDepartmentMaster(Convert.ToInt32(TextBox2.Text));
            if (ds.Tables[0].Rows.Count != 0)
            {
                TextBox1.Text = ds.Tables["department_master"].Rows[0].ItemArray[1].ToString();
            }
            else
            {
                Label1.Text = "record find";
            }
        }
    }
}