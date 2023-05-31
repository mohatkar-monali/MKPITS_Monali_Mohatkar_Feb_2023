using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_equals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "hello";
            string s2 = "llo";
            string s3 = "hello";
            Console.WriteLine(s1.Equals(s2));//Equals method
            Console.WriteLine(s1.Equals(s3));//Equals method
        }
    }
}
