using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhiletable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, i = 1, result;
            Console.WriteLine("enter number");
            num=Convert.ToInt32(Console.ReadLine());    
            do
            {

                result = num * i;
                Console.WriteLine(result);
                i++;
            } while (i <= 10);
            Console.ReadLine();
        }
    }
}
