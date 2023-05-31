using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vowelswitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("enter the character");
            ch=Convert. ToChar(Console.ReadLine());
            switch (ch)
            {
                case 'a':
                    Console.WriteLine("is a vowel");
                    break;
                case 'e':
                    Console.WriteLine("is a vowel");
                    break;
                case 'i':
                    Console.WriteLine("is a vowel");
                    break;
                case 'o':
                    Console.WriteLine("is a vowel");
                    break;
                case 'u':
                    Console.WriteLine("is a vowel");
                    break;

                default:
                    Console.WriteLine("is a consonants");
                    break;
            }
            Console.ReadLine();

        }
    }
}
