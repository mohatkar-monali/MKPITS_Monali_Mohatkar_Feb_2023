using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwith_method
{
    class student
    {
        int rollno;
        string name;

        //creat method getdata
        public void getdata()
        {
            rollno = 123;
            name = "ram";
        }

        //creat a method displaydata
        public void displyadata()
        {
            Console.WriteLine(rollno);
            Console.WriteLine(name);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student stud1 = new student();
           //calling methods
             stud1.getdata();
             stud1.displyadata();
             Console.ReadLine();
        }
    }
}
