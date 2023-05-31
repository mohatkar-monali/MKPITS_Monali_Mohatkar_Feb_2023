using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forfabonaci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1= 0,n2 = 1,result;
            for(int i=0;i<=10;i++)
            {
                result = n1 + n2;
                Console.WriteLine(result);
                n1 = n2;
                n2 = result;
                i++;
            }
            Console.ReadKey();
        }
    }
}
