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
namespace sampleado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //creating string
            string constr = "server=INBOOK_X1\\TEW_SQLEXPRESS;integrated security=true;database=civica;";
            //connection
            SqlConnection conn = new SqlConnection(constr);
            try
            {
                conn.Open();
                label1.Text = "connection successfull";
            }
            catch(Exception ee)
            {
                label1.Text=ee.ToString();
            }
            finally { conn.Close(); }
        }
    }
}
