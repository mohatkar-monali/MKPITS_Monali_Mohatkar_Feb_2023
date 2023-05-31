using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5studentsname_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] name = new string[5];
            for(int i=0; i<name.Length; i++) 
            {
                Console.WriteLine("enter name");
                  name[i] =Console.ReadLine();
            }
            for(int i=0; i<name.Length; i++) 
            {
                Console.WriteLine(name[i]+ "\t");
            }
            Console.ReadKey();
        }
    }
}
