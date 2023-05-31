using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchdesignation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string empname, designation;
            int bonus=0;
            Console.WriteLine("enter the name");
            empname=Console.ReadLine();
            Console.WriteLine("enter the designation as manager,clerk,peon");
            designation = Console.ReadLine();
            switch (designation)
            {
                case "manager":
                    bonus = 10000; 
                    break;
                case"clerk":
                    bonus = 5000;
                    break;
                case "peon":
                    bonus = 2000;
                    break;
               default: Console.WriteLine("invalid designation");
                    break;
            }
            Console.WriteLine("bonus=" + bonus);
            Console.ReadLine();
        }
    }
}
