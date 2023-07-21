using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace arraylistwithclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            Student s1=new Student("Amit",1);
            Student s2 = new Student("Ram", 2);
            Student s3 = new Student("Shyam", 3);
            ar.Add(s1);
            ar.Add(s2);
            ar.Add(s3);
            foreach(Student s in ar)
            {
                Console.WriteLine("Name:"+s.Name);
                Console.WriteLine("RollNo:" + s.RollNo);
            }
         
        }
    }
}
