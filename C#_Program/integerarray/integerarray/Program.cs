using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integerarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr=new int[3];
            arr[0] = 123;
            arr[1] = 234;
            arr[2] = 233;
            foreach(int val in arr) 
            {
                Console.WriteLine("num="+val);
            }
        }
    }
}
