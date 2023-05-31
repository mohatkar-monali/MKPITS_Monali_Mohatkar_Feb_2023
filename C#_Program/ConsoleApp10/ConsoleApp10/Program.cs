using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ulong num;
            Console.WriteLine("enter the number");
            num = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine("enetr number is" + num);
            Console.ReadKey();
        }
    }
    
}
