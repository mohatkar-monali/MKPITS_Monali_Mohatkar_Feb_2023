using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classorder_withpara
{
    class order
    {
        int orderid, mobno;
        string ordername, custmname;
        public void getdata(int id, int mn, string oname, string name)
        {
            orderid = id;
            mobno = mn;
            ordername = oname;
            custmname = name;
        }
        public void displya()
        {
            Console.WriteLine("oredrid=" + orderid);
            Console.WriteLine("mobno=" + mobno);
            Console.WriteLine("ordername=" + ordername);
            Console.WriteLine("custmname=" + custmname);
        }
    }
        internal class Program
        {
            static void Main(string[] args)
            {
                order ord = new order();
                ord.getdata(12, 234578, "samosa", "rani");
                ord.displya();
            }
        }    
}
