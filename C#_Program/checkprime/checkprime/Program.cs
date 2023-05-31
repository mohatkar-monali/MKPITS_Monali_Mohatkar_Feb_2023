using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkprime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enetr number");
            num=Convert.ToInt32(Console.ReadLine());
            checkprime(num);
        }
        static void checkprime(int number)
        {
            int flag= 0;
            for(int counter=2; counter<number; counter++) 
            {
                if(number%counter == 0)
                {
                    flag++;
                    break;
                }
            }
            if(flag == 0)
            {
                Console.WriteLine("is a prime");
            }
            else
            {
                Console.WriteLine("is not prime");
            }
            Console.ReadKey();
        }
    }
}
