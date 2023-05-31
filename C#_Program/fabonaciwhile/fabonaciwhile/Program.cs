using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabonaciwhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i=1, result,n1=0,n2=1;
            while (i <= 10)
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
