using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diamond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height = 5;
            for (int outercounter = height; outercounter >= 1; outercounter--)
            {
                for (int innercounter1 = height; innercounter1 >outercounter; innercounter1--)
                {
                    Console.Write(" ");
                }
                for (int innercounter2 = 1; innercounter2 < (2 * outercounter ); innercounter2++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
