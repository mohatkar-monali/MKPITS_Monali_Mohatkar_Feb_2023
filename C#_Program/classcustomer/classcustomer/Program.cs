using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classcustomer
{
    class customer
    {
        int custmid,mobno;
        string custmname,address;
        public  void getdata()
        {
            custmid = 122;
            mobno = 354672984;
            custmname = "shyam";
            address = "plot 23,wardha road";
        }
        public void displaydata()
        {
            Console.WriteLine("custmid=" + custmid);
            Console.WriteLine("mobnumber=" + mobno);
            Console.WriteLine("custname=" + custmname);
            Console.WriteLine("address=" + address);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            customer custm = new customer();
            custm.getdata();
            custm.displaydata();
            Console.ReadLine();
        }
    }
}
