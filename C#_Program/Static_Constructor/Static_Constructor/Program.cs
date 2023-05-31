using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Constructor
{
    public class Calculate
    {
        public static float pi;
        static Calculate()
        {
            pi = 3.14f;
            Console.WriteLine("Static Constructor");
        }
        public void display()
        {
            Console.WriteLine("rate of intrest=" + pi);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate c1 = new Calculate();
            Calculate c2 = new Calculate();
            c1.display();
            c2.display();
        }
    }
}
