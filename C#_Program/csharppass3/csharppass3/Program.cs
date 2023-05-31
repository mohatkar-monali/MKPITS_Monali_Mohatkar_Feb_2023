using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharppass3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr=new int[3];
            Console.WriteLine("enetr 3 number");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            calculate(arr);
        }
        static void calculate(int[] arr1)
        {
            int result = 0;
            for(int counter=0; counter<arr1.Length; counter++) 
            {
                result = result + arr1[counter];
            }
            Console.WriteLine("addition=" + result);
        }
    }
}
