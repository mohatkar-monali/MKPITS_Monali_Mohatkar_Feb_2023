using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayclone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 9, 4, 1, 7 };
            int[] num =(int[]) array.Clone();
            for(int i=0; i<array.Length; i++) 
            {
                Console.Write(num[i]+ "\t" );
            }
            Console.ReadLine();
        }
    }
}
