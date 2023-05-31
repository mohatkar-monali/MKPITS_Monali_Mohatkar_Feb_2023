using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[5];
            arr[0] = "ram";
            arr[1] = "shyam";
            arr[2] = "rani";
            arr[3] = "amit";
            arr[4] = "ankita";
            foreach (string str in arr) 
            {
                Console.WriteLine("name:"+str);
            }
        }
    }
}
