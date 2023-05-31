using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_contains
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "hello";
            string s2 = "he";
            string s3 = "hi";
            Console.WriteLine(s1.Contains(s2));//Contains method
            Console.WriteLine(s1.Contains(s3));//contains method
        }
    }
}
