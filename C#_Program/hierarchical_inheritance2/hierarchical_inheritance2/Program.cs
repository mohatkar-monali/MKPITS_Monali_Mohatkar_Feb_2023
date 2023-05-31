using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hierarchical_inheritance2
{
    class person
    {
        public string name;
        public string address;
        public void getperdata(string name,string address)
        {
            this.name = name;
            this.address = address;
        }
        public void showperddata()
        {
            Console.WriteLine("name=" + name);
            Console.WriteLine("address=" + address);
        }
    }
    class student : person
    {
        public int rollno;
        public int marks;
        public void getstddata(int rollno,int marks) 
        {
            this.rollno = rollno;
            this.marks = marks;
        }
        public void showstddata() 
        {
            Console.WriteLine("rollno=" + rollno);
            Console.WriteLine("marks=" + marks);
        }
    }
    class employee : person
    {
        public int empid;
        public string designation;
        public void getempdata(int empid,string designation)
        {
            this.empid = empid;
            this.designation = designation;
        }
        public void showempdata()
        {
            Console.WriteLine("empid=" + empid);
            Console.WriteLine("designation=" + designation);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student std=new student(); 
            Console.WriteLine("---------StudentData-------");
            std.getperdata("ram", "chandrapur");
            std.showperddata();
            std.getstddata(12, 500);
            std.showstddata();
             employee emp = new employee();
            Console.WriteLine("---------EmployeeData-------");
            emp.getperdata("shyam", "nagpur");
            emp.showperddata();
            emp.getempdata(123, "director");
            emp.showempdata();
        }
    }
}
