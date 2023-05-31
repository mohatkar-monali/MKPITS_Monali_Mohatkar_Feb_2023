using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whiletable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, i=1,result;
            Console.WriteLine("enter number");
            num=Convert.ToInt32(Console.ReadLine());
            while (i <= 10)
            {
                result = num * i;
                Console.WriteLine(result);
                i++;
            }
            Console.ReadLine();
        }
    }
}
