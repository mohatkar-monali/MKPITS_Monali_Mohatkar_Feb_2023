using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fendalpractice2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = ProductStore.GetProductCategory();
            comboBox1.DataSource= ds.Tables[0];
            comboBox1.DisplayMember = "product_type_name";
            comboBox1.ValueMember = "product_category_id";
        }
    }
}
