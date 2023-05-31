using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radius;
            Console.WriteLine("enter radius");
            radius = Convert.ToInt32(Console.ReadLine());
            float area = 3.14f * radius * radius;
            Console.WriteLine("area = " + area);
            float circumference = 2 * 3.14f * radius;
            Console.WriteLine("circumference = " + circumference);
            Console.ReadLine();
        }
    }
}
