using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace outparameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radius;
            float area, circumference;
            Console.WriteLine("enter radius");
            radius=Convert.ToInt32(Console.ReadLine());
            calculatearea(radius, out area, out circumference);
            Console.WriteLine("area=" + area);
            Console.WriteLine("circumference=" + circumference);
        }
        static void calculatearea(int r,out float area,out float circumference)
        {
            area = 3.14f*r*r;
            circumference = 2*3.14f*r;
        }
    }
}
