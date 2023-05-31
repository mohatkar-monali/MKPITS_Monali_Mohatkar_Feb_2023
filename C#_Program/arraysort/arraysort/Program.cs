using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 1, 9, 6,};
            Array.Sort(array);
            for(int i=0;i<array.Length;i++)
            {
                Console.Write(array[i]+ "\t");
            }
            Console.ReadKey();

        }
    }
}
