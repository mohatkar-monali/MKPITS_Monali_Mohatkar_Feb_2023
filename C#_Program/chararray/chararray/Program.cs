using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chararray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] arr=new char[2];
            arr[0] = 'a';
            arr[1] = 'b';
            foreach (char val in arr) 
            {
                Console.WriteLine("char="+val);
            }
        }
    }
}
