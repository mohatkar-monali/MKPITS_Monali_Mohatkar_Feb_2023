using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpass6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("enter number");
            number=Convert.ToInt32(Console.ReadLine());
            int result=check_primenumber(number);
        }
        static int check_primenumber(int num)
        {
            Boolean isprime=false;
            for(int counter=2; counter<num; counter++)
            {
                if(num%counter == 0)
                {
                    isprime=true;
                    break;
                }
            }
            if(isprime==false)
            {
                Console.WriteLine("entered number is a prime number");
            }
            else 
            {
                Console.WriteLine("entered number is not a prime number");
            }
            return num;
        }
    }
}
