using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1=Convert.ToInt32(textBox1.Text);
            int s2=Convert.ToInt32(textBox2.Text);
            int s3=Convert.ToInt32(textBox3.Text);
            int total=s1+s2+s3;
            label4.Text = "total" + total;
            float per = (total / 300.0f) * 100.0f;
            label5.Text = "percentage"+per;
            if(per == 75)
            {
                label6.Text = "grade:distingtion";
            }
            else if(per ==60 || per < 75)
            {
                label6.Text = "grade:first";
            }
            else if(per==45 && per<60 )
            {
                label6.Text = "grade:pass";
            }
            else
            {
                label6.Text = "grade:fail";
            }
        }
    }
}
