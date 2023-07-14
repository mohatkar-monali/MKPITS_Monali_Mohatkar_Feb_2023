using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fendalpractice1
{
    public partial class Form1 : Form
    {
        enum Nationality
        {
            Indian,NRI
        }
        Nationality nationality;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = ProductStore.GetProductcategory();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "Product_type_Name";
            comboBox1.ValueMember= "Product_Category_Id";
        }

        int cgst = 0;
        int sgst = 0;
        int igst = 0;
        int tgst = 0;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds= ProductStore.GetProductName(comboBox1.Text);
            comboBox2.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "Product_Name";
            comboBox2.ValueMember = "Product_Id";

            DataSet ds1=ProductStore.GetGstDetails(comboBox1.Text);
            foreach(DataRow dr  in ds1.Tables[0].Rows)
            {
                cgst = Convert.ToInt32(dr["cgst"].ToString());
                sgst = Convert.ToInt32(dr["sgst"].ToString());
                igst = Convert.ToInt32(dr["igst"].ToString()) ;
            }
            if (nationality == 0)
            {
                tgst = cgst + igst;
            }
            else
            {
                tgst= cgst;
            }
            textBox3.Text=cgst.ToString();
            textBox4.Text=sgst.ToString(); 
            textBox5.Text=tgst.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds=ProductStore.GetProductPrice(comboBox2.Text);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                textBox9.Text = dr["price"].ToString();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text == "")
            {

            }
            else
            {
                double totalamount=Convert.ToDouble(textBox9.Text)*Convert.ToDouble(textBox10.Text);
                textBox11.Text = totalamount.ToString();
                double cgstamount = Convert.ToDouble(textBox9.Text) * (Convert.ToDouble(textBox3.Text) / 100);
                textBox6.Text= cgstamount.ToString();
                double sgstamount=Convert.ToDouble(textBox9.Text)*(Convert.ToDouble(textBox4.Text)/100);
                textBox7.Text=sgstamount.ToString();
                double igstamount = Convert.ToDouble(textBox9.Text) * (Convert.ToDouble(textBox5.Text) / 100);
                textBox8.Text=igstamount.ToString();
                double netamount = totalamount + igstamount;
                textBox12.Text = netamount.ToString();
            }
        }

        public void Clearall()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clearall();
        }

        public void Checkuerdetails()
        {
            if(textBox1.Text=="" && textBox2.Text == "")
            {
                MessageBox.Show("please enter all details");
            }
            else if (textBox10.Text == "")
            {
                MessageBox.Show("quantity can not be zero");
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Checkuerdetails();
        }
    }
}
