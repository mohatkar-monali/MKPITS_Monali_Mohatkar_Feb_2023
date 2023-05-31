using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_endwith
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "hello";
            string s2 = "llo";
            string s3 = "he";
            Console.WriteLine(s1.EndsWith(s2));//EndsWith method
            Console.WriteLine(s1.EndsWith(s3));//EndsWith method
        }
    }
}
