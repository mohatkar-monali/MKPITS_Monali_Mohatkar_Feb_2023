using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diamond2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            int height = Convert.ToInt32(textBox1.Text);
            for (int outercounter = 1; outercounter <= height; outercounter++)
            {
                for (int innercounter1 = 1; innercounter1 <= height - outercounter; innercounter1++)
                {
                    sb.Append(" ");
                }
                for (int innercounter2 = 1; innercounter2 <= 2 * outercounter - 1; innercounter2++)
                {
                    sb.Append("*");

                }

                sb.Append("\n");
            }
            for (int outercounter = height; outercounter >= 1; outercounter--)
            {
                for (int innercounter1 = height; innercounter1 > outercounter; innercounter1--)
                {
                    sb.Append(" ");
                }
                for (int innercounter2 = 1; innercounter2 < (2 * outercounter); innercounter2++)
                {
                    sb.Append("*");
                }
                sb.Append("\n");
            }

            label1.Text = sb.ToString();

        }
    }
}
