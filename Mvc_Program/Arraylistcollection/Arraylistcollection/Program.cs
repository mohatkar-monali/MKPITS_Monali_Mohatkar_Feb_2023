using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Arraylistcollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar=new ArrayList();
            ar.Add("Amit");
            ar.Add("Raj");
            ar.Add("Ram");

            foreach(object obj in ar)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
