using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ushort number;
            Console.WriteLine("enter the number");
            number = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("number is"+number);
            Console.ReadKey();
        }
    }
}
