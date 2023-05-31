using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum Gender { male,female}
        Gender gender;
        enum Payment
        {
            cash,emi
        }
        Payment payment;

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = ProductDetails.GetProductCategory();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "product_type_name";
            comboBox1.ValueMember = "product_category_id";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds= ProductDetails.GetProductName(comboBox1.Text);
            comboBox2.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "product_name";
            comboBox2.ValueMember = "product_id";

            DataSet ds3 = ProductDetails.GetGstDetails(comboBox1.Text);
            foreach (DataRow dr in ds3.Tables[0].Rows)
            {
                textBox11.Text = dr["cgst"].ToString();
                textBox12.Text = dr["sgst"].ToString();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox2.Text;
           DataSet ds=ProductDetails.GetAvailableQuantity(comboBox2.Text);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                textBox2.Text = dr["Available_Quantity"].ToString();
            }

            DataSet ds1 = ProductDetails.GetTotalQuantity(comboBox2.Text);
            foreach (DataRow dr in ds1.Tables[0].Rows)
            {
                textBox3.Text = dr["Total_Quantity"].ToString();
            }

            DataSet ds2 = ProductDetails.GetPrice(comboBox2.Text);
            foreach (DataRow dr in ds2.Tables[0].Rows)
            {
                textBox4.Text = dr["Price"].ToString();
            }

           

        }
     

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text == "")
            {

            }
            else
            {
                CalculateTotal();
            }
            
        }
        public void CalculateTotal()
        {
            double total = Convert.ToDouble(textBox9.Text) * Convert.ToDouble(textBox4.Text);
            textBox10.Text = total.ToString();
            double cgstamount = Convert.ToDouble(textBox4.Text) * (Convert.ToDouble(textBox11.Text) / 100.0);
            textBox13.Text = cgstamount.ToString();
            double sgstamount = Convert.ToDouble(textBox4.Text) * (Convert.ToDouble(textBox12.Text) / 100.0);
            textBox14.Text = sgstamount.ToString();
            double netamount = Convert.ToDouble(textBox14.Text) * Convert.ToDouble(textBox10.Text);
            textBox15.Text = netamount.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = Gender.male;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender=Gender.female;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            payment = Payment.cash;
            if (radioButton1.Checked)
            {
                textBox7.Text = textBox15.Text;
            }   
        }
    }
}
