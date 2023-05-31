using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace initializing2Darray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] number = { { 1, 2, 3 }, { 1, 2, 3 } };
            for(int i=0;i<2;i++) 
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(number[i,j]+"\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
