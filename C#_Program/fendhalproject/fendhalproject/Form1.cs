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
namespace fendhalproject
{
    public partial class Form1 : Form
    {
        //creating an enum Nationality
        enum Nationality
        {
            Indian,NRI
        }
        public Form1()
        {
            InitializeComponent();
            //code to set date
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.MinDate = DateTime.Today;
        }
        //code to accept only  numbers
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        } 

        private void dateTimePicker1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds =ProductStore.Gettableproductcategory();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "Product_type_Name";
            comboBox1.ValueMember = "Product_Category_Id";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds=ProductStore.GetProductPrice(comboBox2.Text);
            foreach(DataRow dr in ds.Tables[0].Rows)
            {
                textBox9.Text = dr["price"].ToString();
            }
        }
        int cgst = 0;
        int sgst = 0;
        int igst = 0;
        int tgst = 0;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = ProductStore.Gettableproductname(comboBox1.Text);
            comboBox2.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "product_Name";
            comboBox2.ValueMember = "Product_Id";
            //filling the gst textbox
            DataSet ds1=ProductStore.GetGstDetails(comboBox1.Text);
            foreach(DataRow dr in ds1.Tables[0].Rows)
            {
                //textBox3.Text = dr["cgst"].ToString();
                //textBox4.Text = dr["sgst"].ToString();
                //textBox5.Text = dr["igst"].ToString() ;
                cgst=Convert.ToInt32( dr["cgst"].ToString());
                sgst= Convert.ToInt32(dr["sgst"].ToString());
                igst= Convert.ToInt32(dr["igst"].ToString());
            }

            //code for cgst sgst 
            //if (radioButton1.Checked)
         
            if(nationality==0)
            {
                 tgst = cgst + sgst;
            }
            else if(radioButton2.Checked)
            {
                tgst = igst;
            }
            textBox3.Text=cgst.ToString();
            textBox4.Text=sgst.ToString();
            textBox5.Text=tgst.ToString();
        }
        Nationality nationality;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            nationality = Nationality.Indian;
            textBox3.Text=cgst.ToString();
            textBox4.Text=sgst.ToString();
            textBox5.Text=Convert.ToString(Convert.ToInt32(textBox3.Text)+Convert.ToInt32(textBox4.Text));
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            nationality=Nationality.NRI;
            textBox3.Text=cgst.ToString() ;
            textBox4.Text = sgst.ToString();
            textBox5.Text=igst.ToString() ;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text =="")
            {

            }
            else
            {
           double totalamount=Convert.ToDouble(textBox9.Text)*Convert.ToDouble(textBox10.Text);
                textBox11.Text=totalamount.ToString();
                double cgstamount = Convert.ToDouble(textBox9.Text)*(Convert.ToDouble(textBox3.Text) / 100.0);
                textBox6.Text=cgstamount.ToString();
                double sgstamount = Convert.ToDouble(textBox9.Text) * (Convert.ToDouble(textBox4.Text) / 100.0);
                textBox7.Text = sgstamount.ToString();
                double igstamount = Convert.ToDouble(textBox9.Text) * (Convert.ToDouble(textBox5.Text) / 100.0);
                textBox8.Text = igstamount.ToString();
                double netamount = Convert.ToDouble(textBox11.Text) + Convert.ToDouble(textBox8.Text);
                textBox12.Text = netamount.ToString();
            }
        }
        public void ClearAll()
        {
            textBox1.Clear(); 
            textBox2 .Clear();
            textBox3 .Clear();
            textBox4 .Clear();
            textBox5 .Clear();
            textBox6 .Clear();
            textBox7 .Clear();
            textBox8 .Clear();
            textBox9 .Clear();
            textBox10 .Clear();
            textBox11 .Clear();
            textBox12 .Clear();
            
        }
        public void CheckUserDetails()
        {
            if(textBox1.Text=="" && textBox2.Text == "")
            {
                MessageBox.Show("Please fill all the details");
            }
            else if (textBox10.Text == "0")
            {
                MessageBox.Show("quantity can not be zero");
            }
            else
            {
                string result = ProductStore.SaveTableInvoiceDetails(textBox1.Text,Convert.ToInt32(textBox2.Text),Convert.ToInt32(comboBox1.SelectedValue),Convert.ToInt32(comboBox2.SelectedValue),Convert.ToInt32(nationality),Convert.ToDateTime(dateTimePicker1.Text),Convert.ToDecimal(textBox10.Text),Convert.ToDecimal(textBox9.Text),Convert.ToDecimal(textBox3.Text),Convert.ToDecimal(textBox4.Text),Convert.ToDecimal(textBox5.Text),Convert.ToDecimal(textBox6.Text),Convert.ToDecimal(textBox7.Text),Convert.ToDecimal(textBox8.Text),Convert.ToDecimal(textBox11.Text));
                MessageBox.Show(result);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckUserDetails();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

