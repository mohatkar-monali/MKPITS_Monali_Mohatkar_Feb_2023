using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace moveiTickit_booking
{
    internal class BoxOffice:Moviename
    {
        private double bookingfees;
        public int gst = 20;
        public double Bookingfees
        {
            get { return bookingfees; }
            set { bookingfees = value; }
        }
        public override double calculateTicketprice(double price)
        {
              
            return price=gst+price;
        }
    }
}
