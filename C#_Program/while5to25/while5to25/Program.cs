﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while5to25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            while(i<=25)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.ReadKey();
        }
    }
}
