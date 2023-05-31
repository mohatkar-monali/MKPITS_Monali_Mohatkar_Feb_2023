using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace returningarraymethod
{
    internal class Program
    {
        static int[] showarray()
        {
            int[] array = { 4, 8, 5, 2, 1 };
            return array;
        }
        static void Main(string[] args)
        {
            int[] num= showarray();
            foreach(int i in num)
            {
                Console.WriteLine(i);
            }
           Console.ReadKey();
        }
       
    }
}
