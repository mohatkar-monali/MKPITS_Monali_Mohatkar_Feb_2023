using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classmethodwith_parameter
{
    //creating a class
    class student
    {
        int rollno;
        string name;
        
        //creating fucntion
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
            student stud=new student();
            stud.getdata(124, "ram");
            stud.displaydata();
            Console.ReadLine();
        }
    }
}
