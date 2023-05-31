using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studentinformationado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = StudentData.GetstudentData(textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.Text, textBox4.Text);
            label6.Text = result;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Items.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }
    }
}
