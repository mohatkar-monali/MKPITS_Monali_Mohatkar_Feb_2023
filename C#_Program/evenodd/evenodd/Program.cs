using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenodd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("enetr number");
            number= Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("entered number is even");
            }
            else if (number % 2 != 0)
            {
                Console.WriteLine("entered number is odd");
            }
            else { Console.WriteLine("neither even nor odd"); }
             Console.ReadLine();
        }
    }
}
