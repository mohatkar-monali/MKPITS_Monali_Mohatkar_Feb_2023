using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smallfrom3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, number3;
            Console.WriteLine("enetr number1");
            number1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enetr number2");
            number2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enetr number3");
            number3=Convert.ToInt32(Console.ReadLine());

            if ((number1<number2) && (number1<number3)) 
            {
                Console.WriteLine("number1 is small");
            }
            else if((number2<number1) && (number2<number3))
            {
                Console.WriteLine("number2 is small");
            }
            else { Console.WriteLine("number3 is small"); }
            Console.ReadLine();
        }
    }
}
