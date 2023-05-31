using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginform1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int total = 0;
            if(radioButton1.Checked)
            {
                total = total + 10;
            }
            if(radioButton4.Checked) 
            {
                total = total + 10;
            }
            if(radioButton8.Checked) 
            {
                total = total + 10;
            }
            if(radioButton11.Checked)
            {
                total = total + 10;
            }
            int counter = 0;
            if(checkBox1.Checked) 
            {
                counter=counter + 1;
                if (counter < 3)
                {
                    total=total + 5;
                }
                else
                {
                    MessageBox.Show("please select only 2 options");
                }
            }
            if (checkBox2.Checked)
            {
                counter=counter + 1;
                if(counter < 3)
                {
                    total=total - 5;
                }
                else
                {
                    MessageBox.Show("please select only 2 options");
                }
            }
            if (checkBox3.Checked)
            {
                counter = counter + 1;
                if (counter < 3)
                {
                    total = total + 5;
                }
                else
                {
                    MessageBox.Show("please select only 2 options");
                }
            }
            if (checkBox4.Checked)
            {
                counter = counter + 1;
                if (counter < 3)
                {
                    total = total + 5;
                }
                else
                {
                    MessageBox.Show("please select only 2 options");
                }
            }
            if (checkBox5.Checked)
            {
                counter = counter + 1;
                if (counter < 3)
                {
                    total = total - 5;
                }
                else
                {
                    MessageBox.Show("please select only 2 options");
                }
            }
            if (checkBox6.Checked)
            {
                counter = counter + 1;
                if (counter < 3)
                {
                    total = total + 5;
                }
                else
                {
                    MessageBox.Show("please select only 2 options");
                }
            }
            label9.Text = "total out of 60 :" + total;
        }
             int cnt = 0;
             private void timer1_Tick(object sender, EventArgs e)
             {
                  cnt=cnt+1;
                  if(cnt <= 15)
                  {
                     label10.Text = "Time left : 00 : " + cnt.ToString() + " sec";
                  }
                  else

                  {
                      timer1.Enabled = false;
                      button1.Enabled = false;
                      MessageBox.Show("time over");
                  }
             }
    }
}
