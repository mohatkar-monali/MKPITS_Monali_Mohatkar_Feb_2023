using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exStatic_feild
{
    class Account
    {
        public int accno;
        public string name;
        //declaring feild as static
        public static float rateofintrest=4.5f;
        public Account(int accno,string name)
        {
            this.accno = accno;
            this.name = name;
        }
        public void display()
        {
            Console.WriteLine("Account No.=" + accno);
            Console.WriteLine("Name=" + name);
            Console.WriteLine("Rate of Intrest=" + rateofintrest);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account act1 = new Account(123, "Manish");
            Account act2 = new Account(23, "Ram");
            //Account.rateofintrest = 33.4f;

            act1.display();
            act2.display();
        }
    }
}
