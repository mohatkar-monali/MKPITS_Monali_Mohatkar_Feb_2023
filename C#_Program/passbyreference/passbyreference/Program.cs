using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace passbyreference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radius;
            float area, circumference;
            Console.WriteLine("enter radius");
            radius=Convert.ToInt32(Console.ReadLine());
            area = 0.0f;
            circumference = 0.0f;
            calculatearea( radius,ref area,ref circumference);
            Console.WriteLine("area=" + area);
            Console.WriteLine("circumefernce=" + circumference);

        }
        static void calculatearea(int r,ref float a,ref float c) 
        {
            a = 3.14f * r * r;
            c = 2 * 3.14f * r;
        }
    }
}
