using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace factorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number=Convert.ToInt32(textBox1.Text);
            int fact = 1;
            for (int i = 1; i <= number; i++)
            {
               
                fact = fact * i;
                label2.Text = "factorial is" + fact;
            }
            
        }
    }
}
