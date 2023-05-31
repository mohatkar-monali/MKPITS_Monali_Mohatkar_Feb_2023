using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_student
{
    //creating a class student
    class student
    {
        int rollno;
        string name; 
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating object
            student stud1 = new student();
            student stud2 = new student();
            int rollno = 123;
            string name = "monali";
            Console.WriteLine(rollno);
            Console.WriteLine(name);
            Console.ReadLine();
        }
    }
}
