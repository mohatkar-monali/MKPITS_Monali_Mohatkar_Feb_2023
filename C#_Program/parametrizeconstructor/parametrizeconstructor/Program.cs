using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parametrizeconstructor
{
    class student
    {
        int rollno;
        string name;
        public student()
        {
            rollno = 1;
            name = "ram";
        }
        public student(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
        }
        public void display()
        {
            Console.WriteLine("rollno=" + rollno);
            Console.WriteLine("name=" + name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student stud = new student();
            stud.display();
        }
    }
}
