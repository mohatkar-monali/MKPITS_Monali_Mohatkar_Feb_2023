using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employeerecord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gender = null;
            if (radioButton1.Checked)
            {
                label8.Text = EmployeeDetails.InsertEmployeedata(Convert.ToInt32(textBox1.Text), textBox2.Text, radioButton1.Text, textBox3.Text, Convert.ToInt32(textBox4.Text), comboBox1.Text,dateTimePicker1.Text);
            }
            else if (radioButton2.Checked)
            {
                label8.Text = EmployeeDetails.InsertEmployeedata(Convert.ToInt32(textBox1.Text), textBox2.Text, radioButton2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text), comboBox1.Text,dateTimePicker1.Text);
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.Items.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*SqlDataReader dr = EmployeeDetails.GetCity();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["City Name"].ToString());
            }*/

            DataSet ds = EmployeeDetails.GetCity();
            foreach (DataRow dr in ds.Tables["city"].Rows)

            {
                comboBox1.Items.Add(dr["City Name"].ToString());
            }
            DataSet dss= EmployeeDetails.GetEmployee();
            dataGridView1.DataSource = dss.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label8.Text = EmployeeDetails.UpdateEmployeedata(textBox3.Text, comboBox1.Text);
            }
            else if (radioButton2.Checked)
            {
                label8.Text = EmployeeDetails.UpdateEmployeedata(textBox3.Text, comboBox1.Text);
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                label8.Text = EmployeeDetails.DeleteEmployeedata(comboBox1.Text);
            }
            else if (radioButton2.Checked)
            {
                label8.Text = EmployeeDetails.DeleteEmployeedata(comboBox1.Text);
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataSet ds = EmployeeDetails.SearchEmployee(Convert.ToInt32(textBox1.Text));
            dataGridView1.DataSource = ds.Tables[0];
            textBox2.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            string gender = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            if (gender == "male")
                radioButton1.Checked = true;
            else
                radioButton2.Checked = true;
            textBox3.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            textBox4.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
            comboBox1.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
            dateTimePicker1.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
        }
    } 
}
