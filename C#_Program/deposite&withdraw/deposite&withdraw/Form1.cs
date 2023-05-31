using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deposite_withdraw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int bal = 1000;
        private void button1_Click(object sender, EventArgs e)
        {
         
            int amount=Convert.ToInt32(textBox2.Text);
            if (amount > 0) 
            {
                bal = bal + amount;
                label4.Text = "amount deposited bal is" + bal;
            }
            else
            {
                label4.Text = "enetr amount greater than 0";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int amount=Convert.ToInt32(textBox2.Text);
            if (amount <= bal)
            {
                bal = bal - amount;
                label4.Text = "amount withdraw bal is" + bal;
            }
            else
            {
                label4.Text = "insuficient balance";
            }
        }
    }
}
