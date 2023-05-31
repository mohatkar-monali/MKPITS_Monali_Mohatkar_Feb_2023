using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExofEmployee_static
{
    class Employee
    {
        public int empno;
        public string empname;
        public static string companyname = "Google";
        public Employee(int empno,string empname) 
        {
            this.empno = empno;
            this.empname = empname;
        }
        public void display()
        {
            Console.WriteLine("empno=" + empno);
            Console.WriteLine("empname=" + empname);
            Console.WriteLine("company name="+companyname);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(12, "shyam");
            Employee emp1 = new Employee(123, "Ram");
            emp.display();
            emp1.display();
        }
    }
}
