using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, result;
            Console.WriteLine("enter number");
            num=Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <=10 ; i++)
            {
                result = num * i;
                //Console.WriteLine(result);
                Console.WriteLine("{0}*{1}={2}",num,i,result);
            }
            Console.ReadLine();
        }
    }
}
