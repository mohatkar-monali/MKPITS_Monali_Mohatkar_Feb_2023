using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace runtome_overriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amount;
            Console.WriteLine("enetr amount");
            amount=Convert.ToInt32(Console.ReadLine());
            string acttype;
            Console.WriteLine("enter account type saving or current");
            acttype = Console.ReadLine();
            Account act = null;
            if (acttype == "saving")
            {
                act = new Saving();
            }
            else if (acttype == "current")
            {
                act = new Current();
            }
            act.deposite(amount);
        }
        class Account
        {
            public int bal = 1000;
            public virtual void deposite (int amt)
            {
                Console.WriteLine("in account class");
            }
        }
        class Saving : Account
        {
            public int intrest = 500;
            public override void deposite (int amt)
            {
                bal=bal+amt+ intrest;
                Console.WriteLine(bal);
            }
        }
        class Current : Account
        {
            public override void deposite(int amt)
            {
                bal=bal+amt;
                Console.WriteLine(bal);
            }
        }
    }
}
