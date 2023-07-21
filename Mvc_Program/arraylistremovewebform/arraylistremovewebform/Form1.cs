using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace arraylistremovewebform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList ar=new ArrayList();   
        private void button1_Click(object sender, EventArgs e)
        {
            ar.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ar.Insert(2,textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ar.Remove(textBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
        
            ar.RemoveAt(Convert.ToInt32(textBox2.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Capacity" + ar.Capacity);
            MessageBox.Show("Count" + ar.Count);
            StringBuilder sb = new StringBuilder();
            foreach (string s in ar)
            {
                sb.Append(s);
            }
            label3.Text = sb.ToString();
        }
    }
}
