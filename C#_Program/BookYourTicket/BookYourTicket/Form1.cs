using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BookYourTicket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.MinDate = DateTime.Today;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds =BookTicket.GetTheaterName();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "TheaterName";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds=BookTicket.GetMovieName(comboBox1.Text);
            comboBox2.DataSource = ds.Tables[0];
            comboBox2.DisplayMember= "Movie_Name";
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds=BookTicket.GetShowTime(comboBox2.Text);
            comboBox3.DataSource = ds.Tables[0];
            comboBox3.DisplayMember = "Show_Time";

           
            DataSet ds2 =BookTicket.GetPrice(comboBox2.Text);
            comboBox4.DataSource = ds2.Tables[0];
            comboBox4.DisplayMember = "price";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            int total= Convert.ToInt32(Convert.ToInt32(numericUpDown1.Value) * Convert.ToInt32(comboBox4.Text));
            float discount = 0.10f;
            textBox6.Text = Convert.ToString(total-discount);
            textBox3.Text = comboBox2.Text;
            textBox4.Text=comboBox3.Text;
            textBox5.Text=dateTimePicker1.Text;
            label18.Text = "Your Ticket Booked Successfully";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            int total = Convert.ToInt32(Convert.ToInt32(numericUpDown1.Value) * Convert.ToInt32(comboBox4.Text));
            int BookingAmount = 20;
            textBox6.Text = Convert.ToString(total+BookingAmount);
            textBox3.Text = comboBox2.Text;
            textBox4.Text = comboBox3.Text;
            textBox5.Text = dateTimePicker1.Text;
            label18.Text = "Your Ticket Booked Successfully";
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //creating method to clear
        public void ClearAll()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            radioButton1.Enabled= false;
            radioButton2.Enabled= false;
            radioButton3.Enabled= false;
            radioButton4.Enabled= false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label10.Text = BookTicket.InsertBookingDetails(textBox1.Text, textBox2.Text, radioButton1.Text, comboBox1.Text, comboBox2.Text, comboBox3.Text, Convert.ToInt32(numericUpDown1.Value),Convert.ToInt32(comboBox4.Text), Convert.ToDateTime(dateTimePicker1.Text));
            }
            else if(radioButton2.Checked) 
            {
                label10.Text = BookTicket.InsertBookingDetails(textBox1.Text, textBox2.Text, radioButton2.Text, comboBox1.Text, comboBox2.Text, comboBox3.Text,Convert.ToInt32( numericUpDown1.Value),Convert.ToInt32(comboBox4.Text), Convert.ToDateTime(dateTimePicker1.Text));

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
