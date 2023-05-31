using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpass3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {2,2};
            calculate(arr);
            
        }
        static void calculate(int[] arr1)
        {
            int result = 0;  
            for(int counter=0;counter<arr1.Length;counter++)
            {
             
                result= result+ arr1[counter];
          
            }
            Console.WriteLine("addition=" + result);

        }
    }
}
