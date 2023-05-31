using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExOf_Aggrigation
{
    class Address
    {
        public string city;
        public string state;
        public Address(string city,string state)
        {
        this.city = city;
        this.state = state;
        }
        
    }
    class Employee
    {
        public int empno;
        public string empname;
        Address add;//entity reference 
        public Employee(int empno, string empname, Address add)
        {
            this.empno = empno;
            this.empname = empname;
            this.add = add;
        }
        public void display()
        {
            Console.WriteLine("empno=" + empno);
            Console.WriteLine("empname="+empname); 
            Console.WriteLine("city="+add.city); 
            Console.WriteLine("State=" + add.state);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Address a1 = new Address("Nagpur", "Maharashtra");
            Employee emp = new Employee(12,"Monali",a1);
            emp.display();
        }
    }
}
