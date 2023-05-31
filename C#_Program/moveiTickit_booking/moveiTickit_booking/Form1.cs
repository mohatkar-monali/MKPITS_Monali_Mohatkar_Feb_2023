using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace moveiTickit_booking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public object Moveiname { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            string tickettype;
            tickettype = Convert.ToString(comboBox5.Text);
            int price;
            price=Convert.ToInt32(comboBox4.Text);
            Moviename obj = null;
            obj.Moveiname = Convert.ToString(comboBox1.Text);
            obj.Theatername = Convert.ToString(comboBox2.Text);
            obj.Showtime = Convert.ToInt32(comboBox3.Text);
            obj.Seatno = Convert.ToInt32(textBox1.Text);
            obj.Ticketprice = Convert.ToInt32(comboBox4.Text);

            if (tickettype == "online")
            {
                if (price == 100)
                {
                    obj = new OnlineBooking(); double ticket = obj.calculateTicketprice(Convert.ToInt32(price));
                    label8.Text = Convert.ToString(ticket);
                }
                else if (price == 150)
                {
                    obj = new OnlineBooking();
                    double ticket = obj.calculateTicketprice(Convert.ToInt32(price));
                    label8.Text = Convert.ToString(ticket);
                }
                else if (price == 200)
                {
                    obj = new OnlineBooking();
                    double ticket = obj.calculateTicketprice(Convert.ToInt32(price));
                    label8.Text = Convert.ToString(ticket);
                }
            }
            else if (tickettype == "boxoffice")
            {
                if (price == 100)
                {
                    obj = new BoxOffice();
                    double ticket = obj.calculateTicketprice(Convert.ToInt32(price));
                    label8.Text = Convert.ToString(ticket);
                }
                else if (price == 150)
                {
                    obj = new BoxOffice();
                    double ticket = obj.calculateTicketprice(Convert.ToInt32(price));
                    label8.Text = Convert.ToString(ticket);
                }
                else if (price == 200)
                {
                    obj = new BoxOffice();
                    double ticket = obj.calculateTicketprice(Convert.ToInt32(price));
                    label8.Text = Convert.ToString(ticket);
                }
            }
            double res = obj.calculateTicketprice(Convert.ToInt32(price));
            string name = obj.Moveiname;
            string tname = obj.Theatername;
            int time = obj.Showtime;
            int no = obj.Seatno;
            double result= obj.Ticketprice;
            label7.Text = "Movie Name:" +name
                          + "\n" + "Theater Name:" + tname
                          + "\n" + "Show Time:" + time
                          + "\n" + "Seat Number:" + no
                          + "\n" + "Ticket Price:" + result
                          +"\n" +"totalprice:"+res;
            
        }
    }
}
