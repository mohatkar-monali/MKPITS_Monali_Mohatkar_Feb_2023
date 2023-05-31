using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace csharpass4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number;
            Console.WriteLine("enetr decimal number");
            number=Convert.ToDouble(Console.ReadLine());
            double show=calculate_square(number);
            Console.WriteLine("square="+show);
        }
        static double calculate_square(double num)
        {
           double square = num*num;
            return square;
        }
        
    }
}
