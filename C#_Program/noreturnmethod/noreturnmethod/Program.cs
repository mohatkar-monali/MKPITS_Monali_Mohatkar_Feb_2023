using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noreturnmethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("calling  display function");
            display();
            Console.WriteLine("calling again");
            display();
            Console.ReadKey();
        }
        
        static void display() 
        {
            Console.WriteLine("hello world");
        }
         
    }
}
