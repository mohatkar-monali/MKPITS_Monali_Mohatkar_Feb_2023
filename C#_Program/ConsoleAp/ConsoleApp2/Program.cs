using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte num;
            Console.WriteLine("enter the number");
            num=Convert.ToByte(Console.ReadLine());
            Console.WriteLine("number is" + num);
            Console.ReadKey();
        }
    }
}
