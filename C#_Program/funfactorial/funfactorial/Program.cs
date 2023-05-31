using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funfactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number,result;
            Console.WriteLine("enetr number");
            number = Convert.ToInt32(Console.ReadLine());
            result = factorial(number);
            Console.WriteLine("factorial=" + result);
            Console.ReadLine();
        }
        static void factorial(int n1)
        {
            int fact = 1, i = 1, n1;
            
            while (i <= n1)
            {
                fact = fact * i;
                i++;
            }
        }
    }
}
