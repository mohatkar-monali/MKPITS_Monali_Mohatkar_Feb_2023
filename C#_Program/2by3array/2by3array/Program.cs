using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2by3array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //initializing 2D array
            int[,] num = new int[2,3];
            //code to take value from user
            for(int i=0; i<2; i++)
            {
                for(int j=0; j<3; j++)
                {
                    Console.WriteLine("enter number");
                    num[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //codee to display array values
            for(int i=0; i<2;i++)
            {
                for(int j = 0; j<3; j++)
                {
                    Console.Write(num[i,j]+ "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
