using System;
using System.Text;
using System.Windows.Forms;

namespace showmatrix_array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[,] array;
        int row, column;
        int i = 0, j = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    sb.Append(array[i, j] + " ");
                }
                sb.Append("\n");
            }
            label5.Text = sb.ToString();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            int row = Convert.ToInt32(textBox1.Text);
            int column = Convert.ToInt32(textBox2.Text);
            array = new int[row, column];
            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (i < row)
            {
                if (j < column)
                {
                    array[i, j] = Convert.ToInt32(textBox1.Text);
                    textBox3.Clear();
                    textBox3.Focus();
                    j = j + 1;
                }
                if (j == column)
                {
                    i = i + 1;
                    j = 0;
                }
                if (i == row)
                {
                    button2.Enabled = false;
                    button3.Enabled = true;
                }
            }
        }


    }
}
