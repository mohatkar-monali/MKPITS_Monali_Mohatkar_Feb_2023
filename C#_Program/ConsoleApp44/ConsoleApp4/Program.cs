using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short number;
            Console.WriteLine("enter the number");
            number=Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter number is"+number);
            Console.ReadKey();
        }
    }
}
