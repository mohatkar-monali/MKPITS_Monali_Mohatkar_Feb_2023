using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace method_overriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bal = 1000;
            saving s1 = new Savaing();
            s1.deposite(200);
        }



        class Account
        {
            public int bal = 1000;
            public void deposite(int amt)
            {
                Console.WriteLine("deposite method of account class");
            }
        }
        class Saving : Account
        {
            public int intrest = 500;
            public void deposite(int amt)
            {
                bal = bal + amt + intrest;
                Console.WriteLine("bal is" + bal);
            }
        }

    }
}
