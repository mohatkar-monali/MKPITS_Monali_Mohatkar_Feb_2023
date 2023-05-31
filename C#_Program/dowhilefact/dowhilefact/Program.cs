using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhilefact
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, i = 1, fact=1;
            Console.WriteLine("enter number");
            num=Convert.ToInt32(Console.ReadLine());
            do
            {
                fact = fact * i;
                i++; 
            }while(i <= num);
            Console.WriteLine(fact);
            Console.ReadLine();
        }
    }
}
