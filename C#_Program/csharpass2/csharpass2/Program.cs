using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpass2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("enetr string");
            name=Convert.ToString(Console.ReadLine());
            showlength(name);
        }
        static void showlength(string name)
        {
            int len = name.Length;
            Console.WriteLine("length=" + len);
        }
    }
}
