using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();
            array.Add(1);
            array.Add(2);
            array.Add(3);
            array.Add(4);
            array.Add(5);
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Capacity"+array.Capacity);
            Console.WriteLine("Count"+array.Count);
        }
    }
}
