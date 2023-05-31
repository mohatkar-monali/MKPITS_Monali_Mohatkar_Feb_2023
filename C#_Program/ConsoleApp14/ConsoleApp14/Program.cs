using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    //creating sealed class 
    sealed class Employee //this class can not be inherited 
    {
        public void showdata()
        {
            Console.WriteLine("hello world");
        }

    }
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.showdata();
        }
    }
}
