using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_runtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
       
            Account act = null;
            string acttype;
            acttype = Convert.ToString(textBox3.Text);
            if (acttype == "saving") 
            {
                act= new Saving();
                int result =act.deposite(Convert.ToInt32(textBox2.Text));
                label4.Text = Convert.ToString(result);
            }
            else if(acttype=="current") 
            {
                act= new Current();
                int result =act.deposite(Convert.ToInt32(textBox2.Text));
                label4.Text = Convert.ToString(result);
            }
            
            // label4.Text=act.deposite(Convert.ToInt32(textBox2.Text));
            
        }
    }
}
