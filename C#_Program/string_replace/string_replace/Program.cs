using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_replace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "hello F#";
            string s2 = s1.Replace('F', 'C');//Replace method
            Console.WriteLine(s2);
        }
    }
}
