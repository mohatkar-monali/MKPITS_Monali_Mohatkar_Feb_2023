using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace country
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                comboBox2.Text = "";
                comboBox2.Items.Clear();
                string country = comboBox1.Text;
                // MessageBox.Show(country);
                switch (country)
                {

                    case "india":
                        comboBox2.Items.Add("nagpur");
                        comboBox2.Items.Add("mumbai");
                        break;
                    case "usa":
                        comboBox2.Items.Add("frence");
                        comboBox2.Items.Add("europe");
                        break;

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "country" + comboBox1.Text + "\n";
            label3.Text = "city : " + comboBox2.Text + "\n";
            label3.Text += "course : " + listBox1.SelectedItem.ToString() + "\n";
            label3.Text += "phone no : " + maskedTextBox1.Text + "\n";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SetSelected(0, true);
        }

       
    }
}
   

