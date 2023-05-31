using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.CodeDom;

namespace Fendhal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum Nationality
        {
            Indian,NRI
        }
        Nationality nationality;
        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = ProductStore.GetProductCategoryId();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "Product_type_Name";
        }
        int cgst = 0;
        int sgst = 0;
        int igst = 0;
        int tgst = 0;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = ProductStore.Getproductname(comboBox1.Text);
            comboBox2.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "Product_Name";
            comboBox2.ValueMember = "Product_Id";

            DataSet ds1 =ProductStore.Getgstdetails(comboBox1.Text);
            foreach(DataRow dr in ds1.Tables[0].Rows)
            {
                cgst = Convert.ToInt32(dr["cgst"].ToString());
                sgst = Convert.ToInt32(dr["sgst"].ToString());
                igst = Convert.ToInt32(dr["igst"].ToString());
            }
            if (radioButton1.Checked)
            {
                tgst=cgst+sgst;
            }
            else
            {
                tgst = igst;
            }
            textBox3.Text=sgst.ToString();
            textBox4.Text=cgst.ToString();
            textBox5.Text=tgst.ToString();
        }
    }
}
