using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greaterfrom2no
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1,number2;
            Console.WriteLine("enter number1 and number2");
            number1=Convert.ToInt32(Console.ReadLine());
            number2=Convert.ToInt32(Console.ReadLine());
            if (number1 > number2)
            {
                Console.WriteLine("number1 is greater");
            }
            else
            {
                Console.WriteLine("number2 is greater");
            }
            Console.ReadKey();
        }
    }
}
