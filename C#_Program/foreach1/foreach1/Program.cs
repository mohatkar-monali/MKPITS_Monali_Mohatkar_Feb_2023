using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreach1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "amit","raj","rani" };
            foreach(string val in name)
            {
                Console.WriteLine(val);
                Console.ReadLine();
            }
        }
    }
}
