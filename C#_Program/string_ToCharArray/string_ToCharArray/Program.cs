using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_ToCharArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "hello";
            char[] s2 = s1.ToCharArray();//ToCharArray method

            foreach (char c in s2)
            {
                Console.WriteLine(c);
            }
        }
    }
}
