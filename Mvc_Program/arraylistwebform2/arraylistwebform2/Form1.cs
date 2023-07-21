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

namespace arraylistwebform2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList ar=new ArrayList();
        student[] stud = new student[3];
        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            if(i <= 3)
            {
                stud[i - 1] = new student(Convert.ToInt32(textBox1.Text), textBox2.Text);
                ar.Add(stud[i - 1]);
            }
            if (i == 3)
            {
                MessageBox.Show("3 student added");
                button1.Enabled = false;
            }
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach(student stud in ar)
            {
                sb.Append("RollNo:"+stud.Rollno+"\n"+"Name:"+stud.Name+"\n");
            }
            label3.Text = sb.ToString();
        }
    }
}
