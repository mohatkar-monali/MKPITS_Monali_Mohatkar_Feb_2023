﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 3; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
