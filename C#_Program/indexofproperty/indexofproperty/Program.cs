using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexofproperty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 6, 8, 2, 0, 3, 1 };
            int l = Array.IndexOf(num, 8);
            Console.WriteLine("index  " + l);
            Console.ReadKey();
        }
    }
}
