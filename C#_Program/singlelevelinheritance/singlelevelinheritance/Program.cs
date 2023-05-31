using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singlelevelinheritance
{
    class person
    {
        public string  name;
    }
    class student : person
    {
        public int rollno;
    } 
    internal class Program
    {
        static void Main(string[] args)
        {
            student std= new student();
            std.name = "rajesh";
            std.rollno = 12;
            Console.WriteLine(std.name);
            Console.WriteLine(std.rollno);
        }
    }
}
