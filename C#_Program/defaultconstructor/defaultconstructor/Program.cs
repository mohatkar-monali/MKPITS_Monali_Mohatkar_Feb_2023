using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defaultconstructor
{
    class student
    {
        int rollno;
        string name;    
        public student()
        {
            rollno = 123;
            name = "ram";
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
            student s = new student();
            s.display();
        }
    }
}
