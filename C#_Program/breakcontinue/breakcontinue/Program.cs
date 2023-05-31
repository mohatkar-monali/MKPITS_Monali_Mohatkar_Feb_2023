using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace breakcontinue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (true)
            {
                Console.WriteLine(i); 
                i++; 
                if (i < 5)
                    continue; 
                else
                    break; 
            }
            Console.WriteLine("bye");
            Console.ReadKey();
        }
    }
}
