using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchsub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1, s2, result=0;
            char op;
            Console.WriteLine("enter the value for s1");
            s1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enetr the value for s2");
            s2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the operator like +,*");
            op=Convert.ToChar(Console.ReadLine());
            switch (op)
            {
                 case '+':
                    result =s1 + s2;
                    break;
                case '-':
                    result = s1 - s2; 
                    break;
                case '*':
                    result = s1 * s2;
                    break;
                default:
                    Console.WriteLine("invalid operator");
                    break;
            }
            Console.WriteLine("result=" + result);
            Console.ReadLine();
               
        }
    }
}
