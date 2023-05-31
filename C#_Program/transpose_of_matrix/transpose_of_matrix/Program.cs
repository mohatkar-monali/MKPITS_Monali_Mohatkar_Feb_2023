using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transpose_of_matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] num = { { 2, 2 }, { 3, 3 } };
            for(int i=0; i<2; i++)
            {
                for(int j=0;j<2; j++)
                {
                    Console.Write(num[i,j]+ "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("transpose matrix:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(num[j, i] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            
        }
    }
}
