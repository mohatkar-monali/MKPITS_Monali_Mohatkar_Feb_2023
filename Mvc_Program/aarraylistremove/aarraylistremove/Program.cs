using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace aarraylistremove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add(19);
            ar.Add(12);
            ar.Add(13);
            //displaying values of arraylist
            Console.WriteLine("array list colection without sorting");
            foreach (int obj in ar)
            {
                Console.WriteLine("student rno " + obj);
            }
            ar.Remove(13);

            Console.WriteLine("array list colection after removing 13");
            foreach (int obj in ar)
            {
                Console.WriteLine("student rno " + obj);
            }
            ar.RemoveAt(1);

            Console.WriteLine("array list colection after removingat 1");
            foreach (int obj in ar)
            {
                Console.WriteLine("student rno " + obj);
            }




        }
    }
}
