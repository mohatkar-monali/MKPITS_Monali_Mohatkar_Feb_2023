using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritclasstudent
{
    class person
    {
        public string name, address,emailid;
        public int age,mobileno;
        public void getdata(string name,string address,string emailid,int age,int mobileno)
        {
            this.name = name;
            this.address = address;
            this.emailid = emailid;
            this.age = age;
            this.mobileno = mobileno;

        }
        public void display()
        {
            Console.WriteLine("name=" + name);
            Console.WriteLine("address=" + address);

            Console.WriteLine("emailid=" + emailid);
            Console.WriteLine("age=" + age);
            Console.WriteLine("mobileno=" + mobileno);
        }
    }   
    class student:person
    {
        public int rollno;
        public string branch;
        public void getdata(int rollno,string branch, string name, string address, string emailid, int age, int mobileno)
        {
            this.rollno = rollno;
            this.branch = branch;
            getdata(name,address,emailid,age,mobileno);
        }
        public void display()
        {
            
            base.display();
            Console.WriteLine("rollno=" + rollno);
            Console.WriteLine( "branch=" + branch);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student stud = new student();
            stud.getdata(12, "cs", "ram", "chandrapur", "ram@gmail.com", 23, 3456789);
            stud.display();
        }
    }
}
