using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whilefact
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, i = 1, fact = 1;
            Console.WriteLine("enter number");
            num=Convert.ToInt32(Console.ReadLine());
            while (i <= num)
            {
                fact = fact * i; 
                i++; 
            }
            Console.WriteLine(fact);
            Console.ReadLine();
        }
    }
}
