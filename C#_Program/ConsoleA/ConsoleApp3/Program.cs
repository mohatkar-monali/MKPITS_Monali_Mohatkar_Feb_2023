using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte number;
            Console.WriteLine("enter the number");
            number = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("number is" + number);
            Console.ReadKey();        
         }
    }
}
