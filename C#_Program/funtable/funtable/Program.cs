using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enetr number");
            num=Convert.ToInt32(Console.ReadLine());
            table(num);
         
            Console.ReadKey();
        }
        static void table(int n1)
        {
         
            for(int i = 1; i <=10; i++) 
            {
               int cal= n1 * i;
                Console.WriteLine(cal);
            }
            
        }
    }
}
