﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodaddsub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result;
            Console.WriteLine("enter umber1");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number2");
            num2=Convert.ToInt32(Console.ReadLine());
            result=addition (num1, num2);
            Console.WriteLine("addition=" + result);
            result=substraction (num1, num2);
            Console.WriteLine("substraction=" + result);
            Console.ReadKey();
        }
        static int addition(int n1,int n2)
        {
            int result=n1+ n2;  
            return result;
        }
        static int substraction(int n1,int n2)
        {
            int result=n1- n2;
            return result;
        }
    }
}
