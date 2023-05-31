using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_format
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string s1=string.Format("{0:D}",DateTime.Now);//Format method
            Console.WriteLine(s1);
        }
    }
}
