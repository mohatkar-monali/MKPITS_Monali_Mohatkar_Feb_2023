using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getchar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("enetr character");
            ch = Convert.ToChar(Console.ReadLine()); 
            if(ch=='a')
            {
                Console.WriteLine("is a vowel");
            }
            else if (ch == 'e')
            {
                Console.WriteLine("is a vowel");
            }
            else if (ch == 'i')
            {
                Console.WriteLine("is a vowel");
            }
            else if (ch == 'o')
            {
                Console.WriteLine("is a vowel");
            }
            else if (ch == 'u')
            {
                Console.WriteLine("is a vowel");
            }
            else
            {
                Console.WriteLine("is a consonants");
            }
            Console.ReadKey();

        }

    }

}

 

