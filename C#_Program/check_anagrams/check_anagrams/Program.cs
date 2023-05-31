using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_anagrams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enetr string1");
            string s1=Console.ReadLine();
            Console.WriteLine("enter string2");
            string s2 = Console.ReadLine();
            
            char[] arr1= s1.ToCharArray();
            char[] arr2= s2.ToCharArray();

            Array.Sort(arr1);
            Array.Sort(arr2);

            string[] str1 = new string[arr1.Length];
            string[] str2 = new string[arr2.Length];

            if (str1 == str2)
            {
                Console.WriteLine("is an anagrams");
            }
            else
            {
                Console.WriteLine("not an anagrams");
            }

            Console.ReadKey();
        }
    }
}
