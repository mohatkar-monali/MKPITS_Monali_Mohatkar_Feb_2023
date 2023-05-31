using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeno_recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, primeno;
            Console.WriteLine("enter number");
            n1 = Convert.ToInt32(Console.ReadLine());
            primeno = checkprime(n1, n1/2);
            if (primeno == 1)
            {
                Console.WriteLine("the number is prime " + n1);
            }
            else
            {
                Console.WriteLine("the number is not a prime"+n1);
            }
            Console.ReadLine();
        }
        static int checkprime(int n1, int i)
        {
            if (i == 1)
            {
                return 1;
            }
            else 
            {
                if (n1 % i == 0)
                {
                    return 0;
                }
                else 
                {
                    return checkprime(n1,i-1);//calling the function itself recursively 
                }
            }
        }
    }
}
