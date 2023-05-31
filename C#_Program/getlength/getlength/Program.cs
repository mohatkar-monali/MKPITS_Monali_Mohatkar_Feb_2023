using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getlength
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 6, 2, 0, 5 };

            int l = array.GetLength(0);
            Console.WriteLine("length " + l);
            Console.ReadKey();
        }
    }
}
