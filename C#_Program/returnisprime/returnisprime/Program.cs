using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace returnisprime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enetr number");
            num = Convert.ToInt32(Console.ReadLine());
            int result=checkprime(num);
        }  
            static int checkprime(int number)
            {
                int isprime = 0;
                for (int counter = 2; counter < number; counter++)
                {
                    if (number % counter == 0)
                    {
                        isprime++;
                        break;
                    }
                }
                if (isprime == 0)
                { 
                    Console.WriteLine("enetred number is a prime");
                }
                else
                {
                    Console.WriteLine("enetred number is not prime");
                }
                return 0;
                Console.ReadKey();
            }
        
    }
}
