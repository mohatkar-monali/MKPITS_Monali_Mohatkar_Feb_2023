using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classorder_fromuser
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
            order ord=new order();
            Console.WriteLine("enter orderid");
            int orderid=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter mobileno" );
            int mobno=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter ordername");
            string ordername=Console.ReadLine();
            Console.WriteLine("enter custmname");
            string custmname=Console.ReadLine();
            ord.getdata(orderid,mobno, ordername, custmname);
            ord.displya();
            Console.ReadLine();
        }
    }
}
