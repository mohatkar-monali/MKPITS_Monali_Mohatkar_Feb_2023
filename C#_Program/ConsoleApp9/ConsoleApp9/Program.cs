using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, sum;
            Console.WriteLine("enter three numbers");
            num1=Convert.ToInt32(Console.ReadLine());
            num2=Convert.ToInt32(Console.ReadLine()); 
            num3=Convert.ToInt32(Console.ReadLine());
            sum = num1 + num2 + num3;
            Console.WriteLine("Addition is" + sum);
            Console.ReadKey();
        }
    }
}
