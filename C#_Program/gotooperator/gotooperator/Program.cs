using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gotooperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result=0;
            char op;
            Console.WriteLine("enetr 2 numbers");
            num1=Convert.ToInt32(Console.ReadLine());
            num2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enetr iperator like +,-,*");
            op=Convert.ToChar(Console.ReadLine());
            if (op == '+')
            {
                goto addition;
            }
            else if (op == '-')
            {
                goto substraction;
            }
            else if (op == '*')
            {
                goto multiplication;
            }
            else
            {
                goto end;
            }
        addition:
            result = num1 + num2;
            goto end;
        substraction:
            result = num1 - num2;
            goto end;
        multiplication:
            result = num1 * num2;
            goto end;
        end:
            Console.WriteLine("result=" + result);
            Console.ReadKey();        

        }
    }
}
