using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhile5to25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 25);
            Console.ReadKey();
        }
    }
}
