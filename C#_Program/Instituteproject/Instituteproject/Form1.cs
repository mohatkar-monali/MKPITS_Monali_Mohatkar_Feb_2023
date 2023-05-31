using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Instituteproject
{
    public partial class Form1 : Form
    {
        enum Category { student,itprofessional}
        Category category;
        enum Gender {Male,Female,Other }
        Gender gender;
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.MinDate=DateTime.Today;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = "1000";
            DataSet ds = new DataSet();
            ds = CourseRgistration.GetNation();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "NationName";
            comboBox1.ValueMember = "NationId";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox4.Clear();
            category=Category.student;
            textBox2.Text = "1000";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox4.Clear();
            textBox2.Text = "3000";
            category = Category.itprofessional;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                gender=Gender.Male;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                gender = Gender.Female;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = CourseRgistration.SaveTableCourseRegDetails(Convert.ToInt32(category), textBox1.Text, Convert.ToInt32(gender));
            MessageBox.Show(result);
            result = CourseRgistration.SaveTableRegAddress(Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(comboBox3.SelectedValue));
            MessageBox.Show(result);
            result = CourseRgistration.SaveTableFeeDetail(Convert.ToDouble(textBox2.Text),Convert.ToDouble(fp),Convert.ToDouble(textBox3.Text),Convert.ToDouble(textBox4.Text),dateTimePicker1.Value);
            MessageBox.Show(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = CourseRgistration.GetCity(comboBox2.Text);
            comboBox3.DataSource = ds.Tables[0];
            comboBox3.DisplayMember = "CityName";
            comboBox3.ValueMember = "CityId";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = CourseRgistration.GetStates(comboBox1.Text);
            comboBox2.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "StateName";
            comboBox2.ValueMember = "StateId";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        static double fp = 0;
        public void ChaeckBalanceAmount()
        {
            double total=Convert.ToDouble(textBox2.Text);
           
            if (category == 0)
            {
                fp = total * 0.5;
            }
            else
            {
                fp=total * 0.8;
            }
            if(Convert.ToDouble(textBox3.Text) < fp)
            {
                MessageBox.Show("paid amount should be atlest 50% for student and 80% for it professional");
            }
            else
            {
                double balamount = Convert.ToDouble(textBox2.Text) - Convert.ToDouble(textBox3.Text);
                textBox4.Text = balamount.ToString();
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            ChaeckBalanceAmount();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton5.Checked)
            {
                gender = Gender.Other;
            }
        }
        public void ClearAll()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
