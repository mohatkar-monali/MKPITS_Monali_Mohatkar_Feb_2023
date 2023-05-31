using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deposite_withdrawbal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            account acc = new account();
            int result=acc.deposite(Convert.ToInt32(textBox2.Text));
            label3.Text = result.ToString();
            account acc1 = new account();
            int show = acc.withdraw( Convert.ToInt32(textBox2.Text));
            label4.Text = show.ToString();
        }
    }
}
