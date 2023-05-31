using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exenum_byte
{
    enum button : byte
    {
        off,//off denotes the button is switch off with value 0
        on//on denotes the button is switch on with value 1
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 0 or 1");
            byte i=Convert.ToByte(Console.ReadLine());
            if(i ==(byte)button.on)
            {
                Console.WriteLine("switch is on");
            }
            else if(i ==(byte)button.off)
            {
                Console.WriteLine("switch is off");
            }
            else
            {
                Console.WriteLine("byte can not hold such a large value");
            }
        }
    }
}
