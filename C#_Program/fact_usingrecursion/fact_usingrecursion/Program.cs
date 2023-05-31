using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace fact_usingrecursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fact, num;
            Console.WriteLine("enter number");
            num=Convert.ToInt32(Console.ReadLine());
            //creating object to call function
            Program obj=new Program();
            //calling recurcive function
            fact = obj.factorial(num);
            Console.WriteLine( "factorial of{0} is {1}"+num+ fact);
        }
        //recurcive function to calculate factorial
        public int factorial(int num)
        {
            //termination condition
            if (num == 0)
            {
                return 1;
            }
            else
            {
                return num*factorial(num-1);
            }
        }
    }
}
