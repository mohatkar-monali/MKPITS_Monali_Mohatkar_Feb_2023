using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Darray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //code to take a value of array form user
            int[,] array = new int[3, 3];
            for(int row=0; row<3; row++)
            {
                for(int col=0;col<3; col++)
                {
                    Console.WriteLine("enter number");
                    array[row,col]=Convert.ToInt32(Console.ReadLine());
                }
            }
            //code to display value of array
            for(int row=0; row<3;row++)
            {
                for(int col=0; col < 3; col++)
                {
                    Console.Write(array[row, col] +"\t");
                    
                }
                Console.WriteLine();
            }
           
        }
    }
}
