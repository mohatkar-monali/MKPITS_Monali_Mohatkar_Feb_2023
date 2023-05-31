using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moveiTickit_booking
{
    internal class OnlineBooking:Moviename
    {
        private double discount;
        public double Discount
        {
            get { return discount; }
            set{ discount =12;}
        }
        public override double calculateTicketprice(double price)
        {
            return price=price-discount;
        }
    }
}
