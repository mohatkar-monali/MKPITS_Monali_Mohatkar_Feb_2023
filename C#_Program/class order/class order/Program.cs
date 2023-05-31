using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_order
{
    class order
    {
        int orderid,mobno;
        string ordername,custmname;
        public void getdata()
        {
            orderid = 1223;
            mobno =12345689;
            ordername = "smosa";
            custmname ="rani";
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
            order order = new order();
            order.getdata();
            order.displya();
            Console.ReadLine();
        }
    }
}
