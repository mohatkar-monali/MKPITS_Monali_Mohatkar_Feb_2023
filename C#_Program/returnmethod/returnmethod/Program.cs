using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace returnmethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("calling function");
            int result =calculatesquare();
            Console.WriteLine("square=" + result);
            Console.ReadKey();
        }
        static int calculatesquare()
        {
            int number;
            Console.WriteLine("enter number");
            number=Convert.ToInt32(Console.ReadLine());
            int square=number*number;
            return square;
        }
    }
}
