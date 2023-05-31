using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classcustm_fromuser
{
    class customer
    {


        int custmid, mobno;
        string custmname, address;
        public void getdata(int id, int mbno, string name, string add)
        {
            custmid = id;
            mobno = mbno;
            custmname = name;
            address = add;
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
            customer custom = new customer();
            Console.WriteLine("enter id");
            int id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter mobilenumber");
            int mobno=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter name");
            string name=Console.ReadLine(); 
            Console.WriteLine("enter address");
            string address=Console.ReadLine();

            custom.getdata(id, mobno, name, address);
            custom.displaydata();
            Console.ReadLine();
        }
    }
}
