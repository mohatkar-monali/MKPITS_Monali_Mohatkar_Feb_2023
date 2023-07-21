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

namespace arraylistclasswebform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        ArrayList ar=new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            Student s1 = new Student(Convert.ToInt32(textBox1.Text), textBox2.Text);
            Student s2 = new Student(Convert.ToInt32(textBox3.Text), textBox4.Text);
            ar.Add(s1);
            ar.Add(s2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb=new StringBuilder();
            foreach(Student s in ar)
            {
                sb.Append("Name:"+s.Name+"\n"+"RollNo:"+s.Rollno+"\n");
            }
            label5.Text = sb.ToString();
        }
    }
}
