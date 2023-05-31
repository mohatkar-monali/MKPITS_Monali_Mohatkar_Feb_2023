using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height = 10;
            for(int outercounter = 1; outercounter <= height; outercounter++)
            {
                for(int innercounter1=1; innercounter1 <= height - outercounter; innercounter1++)
                {
                    Console.Write(" ");
                }
                for(int innercounter2 = 1; innercounter2 <= 2 * outercounter - 1; innercounter2++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
        }
    }
}
