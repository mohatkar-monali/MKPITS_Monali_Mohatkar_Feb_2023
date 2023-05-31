using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundisplay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            char op;
            Console.WriteLine("enter number1");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number2");
            num2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enetr character");
            op=Convert.ToChar(Console.ReadLine());
            calculate(num1,num2,op);
            Console.ReadKey();
        }
        static void calculate(int n1,int n2,char a) 
        {
            Console.WriteLine("num1=" + n1 +"\t" +"num2=" +n2+"\t"+ "name=" + a);
        }
    }
}
