using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameternoreturn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calculate();
            Console.ReadLine();    
        }
        static void calculate()
        {
            int num1,num2;
            Console.WriteLine("enter number1");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number2");
            num2=Convert.ToInt32(Console.ReadLine());
            addition(num1, num2);
            substraction(num1 , num2);
        }
        static void addition(int n1, int n2)
        {
            int result = n1 + n2;
            Console.WriteLine("addition=" + result);
        }
        static void substraction(int n1, int n2)
        {
            int result = n1 - n2;
            Console.WriteLine("substraction=" + result);
        }

    }
}
