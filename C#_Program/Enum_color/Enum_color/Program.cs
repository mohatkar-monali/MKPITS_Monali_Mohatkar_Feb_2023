using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_color
{
    enum color
    {
        red, yellow, blue,green=yellow+5,brown,black=green+3
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("value of red=" + Convert.ToInt32(color.red));
            Console.WriteLine("value of yellow=" + Convert.ToInt32(color.yellow));
            Console.WriteLine("value of blue="+ Convert.ToInt32(color.blue));
            Console.WriteLine("value of green"+ Convert.ToInt32(color.green));
            Console.WriteLine("value of brown"+ Convert.ToInt32(color.brown));
            Console.WriteLine("value of black"+ Convert.ToInt32(color.black));
        }
    }
}
