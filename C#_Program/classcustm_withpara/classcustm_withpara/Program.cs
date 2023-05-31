using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classcustm_withpara
{
    class customer
    {
        int custmid, mobno;
        string custmname, address;
        public void getdata(int id,int mbno,string name,string add)
        {
            custmid = id;
            mobno = mbno;
            custmname = name;
             address = add;
        }
        public void display()
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
            custm.getdata(123, 23984576, "rajesh", "plot no 213,jalgaon");
            custm.display();
            Console.ReadKey();
        }
    }
}
