﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exof_finallyBlock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10;
            int n2 = 0;
            int res = 0;
            try
            {
                res = n1 / n2;
                Console.WriteLine("Result=" + res);
            }
            catch(DivideByZeroException ee) 
            {
                Console.WriteLine(ee.ToString());
            }
            finally 
            {
                Console.WriteLine("finally exicuted"); 
            }
            Console.WriteLine("Bye");
        }
    }
}
