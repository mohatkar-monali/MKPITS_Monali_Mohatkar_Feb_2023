using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_palinndrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter string");
            string name=Console.ReadLine();
            string reversestr = "";
            for(int i=name.Length-1; i>=0; i--)
            {
                 reversestr=reversestr + name[i];
            }
            Console.WriteLine(reversestr);
            Console.ReadLine();
        }
    }
}
