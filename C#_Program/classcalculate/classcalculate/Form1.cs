﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classcalculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculate cal=new Calculate();
            int result = cal.calculateresult(Convert.ToInt32(textBox1.Text),
                                             Convert.ToInt32(textBox2.Text),
                                             Convert.ToChar(comboBox1.Text));
            label4.Text = "result="+result.ToString();
        }
    }
}
