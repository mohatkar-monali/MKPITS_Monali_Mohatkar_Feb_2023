using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moveiTickit_booking
{
    internal class Moviename
    {
        private string moveiname;
        private string theatername;
        private int showtime;
        private int seatno;
        private int ticketprice;
        public string Moveiname
        {
            get { return moveiname; }
            set { moveiname = value; }
        }
        public string Theatername
        {
            get { return theatername; }
            set { theatername = value; }
        }

        public int Showtime
        {
            get { return showtime; }
            set { showtime = value; }
        }
        public int Seatno
        { 
            get { return seatno; } 
            set { seatno = value; } 
        }
        public int Ticketprice
        {
            get { return ticketprice; }
            set { ticketprice = value;}
        }
        public virtual double calculateTicketprice(double price)
        {
            return price;
        }
       
    }
}
