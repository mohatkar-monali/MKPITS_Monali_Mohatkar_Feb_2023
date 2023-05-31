using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace varlengthparameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total;
            total = calculate(3, 5, 7, 8, 9);
            Console.WriteLine("total="+total);
        }
        static int calculate(params int[] val)
        {
            int total = 0;
            for(int counter=1;counter<val.Length;counter++)
            {
                total = total + val[counter];
            }
            return total; 
        }
    }
}
