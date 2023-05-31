using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace show_index
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "amitabh";
            char[] aaray = str.ToCharArray();
            Console.WriteLine(str);

            Console.WriteLine("enetr character from above string");
            char ch;
            ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'a')
            {
                Console.WriteLine(Array.IndexOf(aaray,'a').ToString());
            }
            else if (ch == 'm')
            {
                 Console.WriteLine(Array.IndexOf(aaray, 'm').ToString());
            }
            else if (ch == 'i')
            {
                Console.WriteLine(Array.IndexOf(aaray, 'i').ToString());
            }
            else if(ch == 't')
            {
                Console.WriteLine(Array.IndexOf(aaray, 't').ToString());
            }
            else if (ch == 'a')
            {
                Console.WriteLine(Array.IndexOf(aaray, 'a').ToString());
            }
            else if (ch == 'b')
            {
                Console.WriteLine(Array.IndexOf(aaray, 'b').ToString());
            }
            else 
            {
                Console.WriteLine(Array.IndexOf(aaray, 'h').ToString());
            }
            Console.ReadLine();
        }
    }
}
