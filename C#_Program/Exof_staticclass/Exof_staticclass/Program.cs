using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exof_staticclass
{
    public static class Calculate
    {
        public static float pi = 3.14f;
        public static int cube(int n)
        {
            return n * n * n;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pi="+Calculate.pi);
            Console.WriteLine("Cube="+Calculate.cube(3));
        }
    }
}
