using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_Random
{
    //creating enum random
    enum random
    {
        a,b,c=6,d,e=4,f
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("value for a is" + Convert.ToInt32(random.a));//0
            Console.WriteLine("value of b is" + Convert.ToInt32(random.b));//1
            Console.WriteLine("value for c is"+Convert.ToInt32(random.c));//6
            Console.WriteLine("value for d is" +Convert.ToInt32( random.d));//7
            Console.WriteLine("value for e is" +Convert.ToInt32( random.e));//4
            Console.WriteLine("value for f is" + Convert.ToInt32(random.f));//5
        }
    }
}
