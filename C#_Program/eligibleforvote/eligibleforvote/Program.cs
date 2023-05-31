using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eligibleforvote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("enter the age");
            age=Convert.ToInt32(Console.ReadLine());
            if (age<18) 
            {
                Console.WriteLine("YOU ARE ELIGIBLE");
            }
            else
            {
                Console.WriteLine("YOU ARE NOT ELIGIBLE");
            }
            Console.ReadKey();
        }
    }
}
