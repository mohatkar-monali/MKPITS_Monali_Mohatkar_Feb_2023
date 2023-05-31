using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add2array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array1 = { { 22, 45 }, { 61, 21 } };
            int[,] array2 = { { 41, 21 }, { 34, 12 } };
            int[,] array3 = new int[2, 3];
            for(int i=0; i<2; i++)
            {
                for (int j = 0; j <2; j++)
                {
                    array3[i,j] = array1[i,j] + array2[i,j];
                }
            }
            for(int i=0; i<2; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    Console.Write(array3[i,j]+ "\t" );
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
