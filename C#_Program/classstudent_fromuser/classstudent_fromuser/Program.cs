using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classstudent_fromuser
{
    class student
    {
        int rollno;
        string name;
        public void getdata(int rn,string n)
        {
           rollno = rn;
            name = n;
        }
        public void displaydata() 
        {
            Console.WriteLine(rollno);
            Console.WriteLine(name);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter rollno");
            int rollno=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter name");
            string name = Console.ReadLine();

            student stud = new student();
            stud.getdata(rollno, name);
            stud.displaydata();
            Console.ReadLine();
        }
    }
}
