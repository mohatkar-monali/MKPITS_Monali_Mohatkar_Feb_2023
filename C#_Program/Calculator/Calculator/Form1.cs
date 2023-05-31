using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int value1;
        int value2;
        char op;
        int result = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
            label1.Text = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
            textBox1.Text = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
            label1.Text = textBox1.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
            label1.Text = textBox1.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
            label1.Text = textBox1.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
            label1.Text = textBox1.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
            label1.Text = textBox1.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
            label1.Text = textBox1.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
            label1.Text = textBox1.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
            label1.Text = textBox1.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(textBox1.Text);
            op = '+';
            textBox1.Text = "";
            textBox1.Text += op;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(textBox1.Text);
            op = '-';
            textBox1.Text = "";
            label1.Text += op;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(textBox1.Text);
            op = '*';
            textBox1.Text = "";
            label1.Text += op;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(textBox1.Text);
            op = '/';
            textBox1.Text = "";
            label1.Text += op;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            value2 = Convert.ToInt32(textBox1.Text);
            textBox1.Text = textBox1.Text;
            if (op == '+')
            {
                result = value1 + value2;
                textBox1.Text = Convert.ToString(result);
            }
            else if (op == '-')
            {
                result = value1 - value2;
                textBox1.Text = Convert.ToString(result);
            }
           else if (op == '*')
            { 
                result = value1 * value2;
                textBox1.Text = Convert.ToString(result);
            }
            else if (op == '/')
            {
                result = value1 + value2;
                textBox1.Text = Convert.ToString(result);
            }
            else
            {
                textBox1.Text = "invalid operator";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

      
    }
}