using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3by3array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] number = new int[3, 2]; 
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    Console.WriteLine("enetr number");
                    number[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for(int i = 0;i < 3;i++) 
            {
                for(int j=0; j < 2; j++) 
                {
                    Console.Write(number[i, j]+ "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
