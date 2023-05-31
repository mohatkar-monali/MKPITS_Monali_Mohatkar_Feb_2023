using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExOf_Enum
{
    class Perimeter
    {
        public enum shape
               {
                    circle,square
               }
        public void peri(int val,shape s1)
        {
            if (s1 == 0)
            {
                float cir = 2 * 3.14f * val;
                Console.WriteLine("circumference of a circle is"+cir);
            }
            else
            {
                int perimeter = 4 * val;
                Console.WriteLine("perimeter of a square is" + perimeter);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Perimeter p = new Perimeter();
            p.peri(3,Perimeter.shape.circle);
            p.peri(4,Perimeter.shape.square);
        }
    }
}
