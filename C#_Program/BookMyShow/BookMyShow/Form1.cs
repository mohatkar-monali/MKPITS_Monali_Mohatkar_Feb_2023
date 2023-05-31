using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookMyShow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            comboBox3.Text = ""; 
            switch(comboBox1.Text)
            {
                case "kbkj":
                    comboBox2.Items.Add("Liberty");
                    comboBox2.Items.Add("Cenemax");
                    break;
                case "Bhola":
                    comboBox2.Items.Add("Smruti");
                    comboBox2.Items.Add("Inox");
                    break;
                case "ddlj":
                    comboBox2.Items.Add("Alankar");
                    comboBox2.Items.Add("Sudama");
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           // textBox1.Text = "0";
            comboBox3.Items.Clear();
            comboBox3.Text = "";
            switch(comboBox2.Text)
            {
                case "Liberty":
                    comboBox3.Items.Add("12:00PM");
                    comboBox3.Items.Add("03.00PM");
                    textBox1.Text = "120";
                    break;
                case "Cinemax":
                    comboBox3.Items.Add("10:30AM");
                    comboBox3.Items.Add("01:30AM");
                    textBox1.Text = "420";
                    break;
                case "Smruti":
                    comboBox3.Items.Add("12:30AM");
                    comboBox3.Items.Add("06:30AM");
                    textBox1.Text = "300";
                    break;
                case "Inox":
                    comboBox3.Items.Add("09:30PM");
                    comboBox3.Items.Add("12:00PM");
                    textBox1.Text = "250";
                    break;
                case "Alankar":
                    comboBox3.Items.Add("10:00PM");
                    comboBox3.Items.Add("01:30PM");
                    textBox1.Text = "150";
                    break;
                case "Sudama":
                    comboBox3.Items.Add("02:00PM");
                    comboBox3.Items.Add("03:00PM");
                    textBox1.Text = "130";
                    break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Movie_Ticket mt = null;
            if (radioButton1.Checked)
            {
                mt = new Online_Booking(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(textBox1.Text));
            }
            else if (radioButton2.Checked)
            {
                mt = new Box_Office(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(textBox1.Text));

            }
            label7.Text = mt.Calculate_Ticket_Price();
        }
    }
}
