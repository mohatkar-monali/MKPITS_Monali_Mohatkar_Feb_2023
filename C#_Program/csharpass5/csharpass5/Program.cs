using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpass5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("enetr string");
            name=Console.ReadLine();
            string show=show_palindrome(name);
            Console.WriteLine("is a pallendrome="+show);
        }
        static string show_palindrome(string palindrome)
        {
           
            string pal=palindrome;
            char [] array=pal.ToCharArray();
            Array.Reverse(array);
            string reversed= new string(array);
        
            return reversed;
        }

    }
}
