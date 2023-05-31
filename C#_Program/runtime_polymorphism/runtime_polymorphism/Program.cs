using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace runtime_polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account act = new Saving();
            act.deposite(200);
            Console.ReadKey();
        }
        class Account
        {
           public int bal = 1000;
            public virtual void deposite(int bal)
            {
                Console.WriteLine("in deposite method of account class");
            }
            
        }
        class Saving:Account
        {
            int interest = 500;
            public override void deposite(int amt)
            {
                bal=bal+interest+amt;
                Console.WriteLine(bal);

            }
        }
    }
}
