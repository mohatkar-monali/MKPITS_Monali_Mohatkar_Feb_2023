using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greaterfrom3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1,number2,number3;
            Console.WriteLine("enter number1");
            number1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number2");
            number2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number3");
            number3=Convert.ToInt32(Console.ReadLine());

            if ((number1 > number2) && (number1 > number3) )
            {
                Console.WriteLine("number1 is greater");
            }
            else if((number2 > number1) && (number2 > number3))
            {
                Console.WriteLine("number2 is greater");
            }
            else { Console.WriteLine("number3 is greater"); }
            Console.ReadLine();
        }
    }
}
