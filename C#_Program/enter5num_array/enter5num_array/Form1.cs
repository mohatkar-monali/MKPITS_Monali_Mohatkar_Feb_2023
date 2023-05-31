using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enter5num_array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int[] number = new int[5];
            for (int i=0;i<5; i++)
            {
                
                 number[i] = Convert.ToInt32(textBox1.Text);
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] number = new int[5];
        
            for (int i=0;i<5;i++)
            {
                 number[i] = Convert.ToInt32(textBox1.Text);   
                 label2.Text = number[i] + "\t";
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int[] number = new int[5];
            for (int i = 0; i < 5; i++)
            {
                number[i] = Convert.ToInt32(textBox1.Text);
            }
           
        }
    }
}
