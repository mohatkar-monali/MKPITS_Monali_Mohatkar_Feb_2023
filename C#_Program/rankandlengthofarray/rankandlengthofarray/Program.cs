﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rankandlengthofarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] num = new int[2, 3];
            for(int i=0; i<2; i++)
            {
                for(int j=0; j<3; j++)
                {
                    Console.WriteLine("enter number");
                    num[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for(int i=0; i<2; i++) 
            {
                for(int j=0 ; j<3 ; j++) 
                {
                    Console.Write(num[i, j]+ "\t");
                }
                Console.WriteLine();
               
            }
            Console.WriteLine("rank " + num.Rank);
            Console.WriteLine("length " + num.Length);
            Console.ReadKey();

        }
    }
}
