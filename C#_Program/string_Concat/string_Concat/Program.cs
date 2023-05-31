using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_Concat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello";
            string s2 = "World";
            Console.WriteLine(String.Concat(s1,s2));//concat method
        }
    }
}
