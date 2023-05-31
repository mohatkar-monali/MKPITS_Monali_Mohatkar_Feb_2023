using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isprimeornot
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int num,flag = 0;
            Console.WriteLine("enter number");
            num=Convert.ToInt32(Console.ReadLine());
            for(int counter=2; counter<num; counter++)
            {
                if(num%counter==0)
                {
                    flag = 1;
                    break;
                }
            }
            if(flag == 0)
            {
                Console.WriteLine(" is a prime number");
            }
            else
            {
                Console.WriteLine(" is not a prime number");
            }
            Console.ReadKey();
        }
        
    }
}
