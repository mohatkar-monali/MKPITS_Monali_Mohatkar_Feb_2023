using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace aspcashemi
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable("dtable");
            DataRow dr;
            dt.Columns.Add(new DataColumn("Id", typeof(int)));
            dt.Columns.Add(new DataColumn("name", typeof(string)));
            dt.Columns.Add(new DataColumn("date", typeof(DateTime)));
            dr = dt.NewRow();
            dr[0] = 1;
            dr[1] = "Monali";
            dr[2] = DateTime.Now;
            dt.Rows.Add(dr);
            ds.Tables.Add(dt);
            GridView1.DataSource = ds.Tables["dtable"].DefaultView;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int totalamount = Convert.ToInt32(TextBox1.Text);
            int pamounnt = Convert.ToInt32(TextBox2.Text);
            int ramount = totalamount - pamounnt;
            double eamount = 0;

            if (RadioButton1.Checked)
            {
                if (ramount > 0)
                {
                    Label1.Text= "please pay full amount";
                }
            }
            else if (RadioButton2.Checked)
            {
                if (ramount > 0)
                {
                    eamount = ramount / 3.0;
                }
                string pname = "mouse";

                DataSet ds = new DataSet();
                DataTable dt = new DataTable("emitable");
                DataRow dr;
                dt.Columns.Add(new DataColumn("srno", typeof(int)));
                dt.Columns.Add(new DataColumn("pname", typeof(string)));
                dt.Columns.Add(new DataColumn("emiamount", typeof(int)));

                for (int i = 1; i <= 3; i++)
                {
                    dr = dt.NewRow();
                    dr[0] = i;
                    dr[1] = pname;
                    dr[2] = eamount;
                    dt.Rows.Add(dr);
                }

                ds.Tables.Add(dt);
                GridView2.DataSource = ds.Tables["emitable"].DefaultView;
                GridView2.DataBind();

            }
        }
    }
}