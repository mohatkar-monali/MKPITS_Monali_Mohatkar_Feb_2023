using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hierarchical_inheritance
{
    class person
    {
        public string name;
        public string address;

    }
    class student : person
    {
        public int rollno;
        public int marks;
    }
    class employee : person
    {
        public int empid;
        public string designation;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student std = new student();
            std.name = "ram";
            std.address = "naagpur";
            std.marks = 500;
            std.rollno = 12;
            Console.WriteLine("----------Student Data---------");
            Console.WriteLine("name=" + std.name);
            Console.WriteLine("rollno=" + std.rollno);
            Console.WriteLine("address=" + std.address);
            Console.WriteLine("marks=" + std.marks);
            employee emp = new employee();
            emp.name = "shyam";
            emp.address = "Amravati";
            emp.empid = 123;
            emp.designation = "Manager";
            Console.WriteLine("-----------Employee Data---------");
            Console.WriteLine("name=" + emp.name);
            Console.WriteLine("address=" + emp.address);
            Console.WriteLine("empid=" + emp.empid);
            Console.WriteLine("designation=" + emp.designation);
        }
    }
}
