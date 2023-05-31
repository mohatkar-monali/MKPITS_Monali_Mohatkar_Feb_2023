using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleararray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 15, 23, 78, 21 };
            Array.Clear(number,0,2);
            for(int i=0; i<number.Length; i++)
            {
                Console.Write(number[i]);
            }
            Console.ReadKey();
        }
    }
}
