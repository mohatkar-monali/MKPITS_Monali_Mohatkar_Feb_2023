using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passbyvaluedefault
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            Console.WriteLine("value of num inside main  before passing ="+num);
            display(num);
            Console.WriteLine("value of num after passing ="+num);
        }
        static void display(int num)
        {
           num=num+2;
            Console.WriteLine("value of num inside display ="+ num);
        }
    }
}
