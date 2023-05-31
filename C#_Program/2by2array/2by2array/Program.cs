using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2by2array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //initializing 2D array(2,2)

            int[,] array = new int[2, 2];
            //code to take values from user
            for(int i = 0; i < 2; i++)
            {
                for(int j=0;j< 2; j++)
                {
                    Console.WriteLine("enter number");
                    array[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //code to diplay array values
            for(int i = 0; i < 2; i++)
            {
                for(int j=0; j < 2; j++)
                {
                    Console.Write(array[i, j]+ "\t");
                }
                Console.WriteLine();
            }
          Console.ReadKey();
        }
    }
}
