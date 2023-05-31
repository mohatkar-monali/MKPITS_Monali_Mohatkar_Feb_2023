using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace callfuninsidefun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calculate();
        }
         static void calculate() 
        {
            int num1, num2, result;
            Console.WriteLine("enter number1");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number2");
            num2=Convert.ToInt32(Console.ReadLine());
            result=addition(num1,num2);
            Console.WriteLine("addition=" + result);
            result=substraction(num1 ,num2);
            Console.WriteLine("substraction=" + result);
            Console.ReadLine();
        }
        static int addition(int n1,int n2)
        {
            int result = n1 + n2;
            return result;
        }
        static int substraction(int n1,int n2)
        {
            int result = n1 - n2;
            return result;
        }

    }
}
