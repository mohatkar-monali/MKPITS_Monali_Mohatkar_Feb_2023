using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace multilevel1
{
    class person
    {
        public string name;
        public string address;
        public void getpersondata(string name,string address)
        {
              this.name = name;
              this.address = address;
        }
        public void showpersondata()
        {
            Console.WriteLine("name=" + name);
            Console.WriteLine("address=" + address);
        }
    }
    class employee:person 
    {
        public int salary;
        public string designation;
        public void getemployeedata(int salary,string designation)
        {
              this.salary = salary;
            this.designation = designation;
        }
        public void showemployeedata()
        {
            Console.WriteLine("salary="+salary);
            Console.WriteLine("designation=" + designation);
        }
    }
    class parttimeemp : employee
    {
        public int no_of_hours;
        public void getdata(int no_of_hours)
        {
            this.no_of_hours = no_of_hours;
        }
        public void showempdata()
        {
            Console.WriteLine("no of hours="+no_of_hours);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            parttimeemp emp=new parttimeemp();
            emp.getpersondata("ram", "nagpur");
            emp.getemployeedata(15000, "Manager");
            emp.getdata(5);
            emp.showpersondata();
            emp.showemployeedata();
            emp.showempdata();
        }
    }
}
