using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhilefabonaci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i=0,n1= 0,n2 = 1,result;
            do
            {
                result = n1 + n2;
                Console.WriteLine(result);
                i++;
                n1 = n2;
                n2 = result;

            }while(i <=10);
            Console.ReadKey();
        }
    }
}
