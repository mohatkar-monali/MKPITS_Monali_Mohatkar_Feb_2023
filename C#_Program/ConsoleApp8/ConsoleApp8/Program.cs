using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rollno, age, mobileno;
            string name, course;
            Console.WriteLine("enter the name");
            Console.WriteLine("enter the rollno");
            Console.WriteLine("enter the age");
            Console.WriteLine("enter the mobileno");
            Console.WriteLine("enter the course");
            rollno=Convert.ToInt32(Console.ReadLine());
            age=Convert.ToInt32(Console.ReadLine());    
            mobileno=Convert.ToInt32(Console.ReadLine());
            name=Console.ReadLine();
            course=Console.ReadLine();
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Rollno:" + rollno);
            Console.WriteLine("age:" + age);
            Console.WriteLine("mobileno:"+mobileno);
            Console.WriteLine("course:" + course);
            Console.ReadLine();
        }
    }
}
