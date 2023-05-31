using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace exof_abstractclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amount;
            Console.WriteLine("enter amount");
            amount=Convert.ToInt32(Console.ReadLine());
            Account act= null;
            string actype;
            Console.WriteLine("enter saving and current");
            actype = Console.ReadLine();
            if (actype == "current")
            {
                act = new Saving();
               
              
            }
            else if (actype == "saving")
            {
                act = new Current();
            }
                int res = act.deposite(amount);
                Console.WriteLine(res);
            
           
            Console.ReadLine();
        }
        abstract class Account
        {
            public int bal = 1000;
            public abstract int deposite(int amt);
            public string showbalance()
            {
                return "bal";
            }

        }
        class Saving:Account
        {
            public int interst = 500;
            public override int deposite(int amt) 
            {
                 bal=amt+bal+interst;
                return bal;
            }
        }
        class Current:Account
        {
            public override int deposite(int amt)
            {
                bal = amt + bal;
                return bal;
            }
        }
    }
}
