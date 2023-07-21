using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListSorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar= new ArrayList();
            ar.Add(1);
            ar.Add(4);
            ar.Add(3);
            Console.WriteLine("Arraylist withounnt sorting");
            foreach (int i in ar)
            {
                Console.WriteLine("Std rollno:"+i);
            }
            Console.WriteLine("ArrayList with  sorting");
            ar.Sort();
            foreach (int i in ar)
            {
                Console.WriteLine("Stud rollno:"+i);
            }
        }
    }
}
