

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hierarchical_inheritace3
{
    class vehical
    {
        public string vname;
        public int vno;
        public void getvehicaldata(string vname, int vno)
        {
            this.vname = vname;
            this.vno = vno;
        }
        public void displayvehicaldata()
        {
            Console.WriteLine(vname);
            Console.WriteLine(vno);
        }
    }
    class bus:vehical
    {
        public int no_of_seats;
        public void getbusdata(int no_of_seats)
        {
            this.no_of_seats = no_of_seats;
        }
        public void displaybusdata() 
        {
            Console.WriteLine("No_Of_Seats="+no_of_seats);
        }
    }
    class car:vehical
    {
        public int cc;
        public void getcardata(int cc)
        {
            this.cc = cc;
        }
        public void displaycardata()
        {
            Console.WriteLine("cc=" + cc);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            bus bus = new bus();
            bus.getvehicaldata("Star Bus", 56387);
            bus.displayvehicaldata();
            bus.getbusdata(30);
            bus.displaybusdata();
            car c = new car();
            c.getvehicaldata("Maruti", 456);
            c.displayvehicaldata() ;
            c.getcardata(1200);
            c.displaycardata();
        }
    }
}
