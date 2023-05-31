using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace useoperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2,result=0;
            char op;
            Console.WriteLine("enter number1");
            number1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number2");
            number2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter operator like +,-,*");
            op=Convert.ToChar(Console.ReadLine());

            if (op == '+')
            {
                result = number1 + number2;
            }
            else if (op == '-')
            {
                result = number1 - number2;
            }
            else if (op == '*')
            {
                result = number1 * number2;
            }
            else 
            {
                Console.WriteLine("invalid operator");
            }
            Console.WriteLine("Result=" + result);
            Console.ReadKey();
        }
    }
}
