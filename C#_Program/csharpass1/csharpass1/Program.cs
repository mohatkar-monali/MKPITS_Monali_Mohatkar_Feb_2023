
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpass1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2,addition;
            Console.WriteLine("enter number1");
            number1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number2");
            number2=Convert.ToInt32(Console.ReadLine());
            addition=calculateadd(number1 ,number2);
            Console.WriteLine("addition=" + addition);
        }
        static int calculateadd(int num1, int num2)
        {
            int sum=num1 + num2;
            return sum;
        }
    }
}
