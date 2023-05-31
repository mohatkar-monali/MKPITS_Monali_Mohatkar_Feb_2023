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

namespace selectfromdropdown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            comboBox2.Items.Clear();
            string country = comboBox1.Text;
            switch (country)
            {
                case "India":
                    comboBox2.Items.Add("Nagpur");
                    comboBox2.Items.Add("Chandrapur");
                    comboBox2.Items.Add("Amravati");
                    comboBox2.Items.Add("Sambhajinagar");
                    break;
                case "USA":
                    comboBox2.Items.Add("La");
                    comboBox2.Items.Add("Newyork");
                    comboBox2.Items.Add("Shikago");
                    break;


            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = "country : " + comboBox1.Text + "\n";
            label4.Text += "city : " + comboBox2.Text + "\n";
            label4.Text += "course : " + listBox1.SelectedItem.ToString() + "\n";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SetSelected(0, true);
        }

    }
}
    

