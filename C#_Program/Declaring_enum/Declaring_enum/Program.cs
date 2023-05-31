using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Declaring_enum
{
    //creating enu for month
    enum month
    {
        jan,feb,march,april
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("value for jan is"+Convert.ToInt32(month.jan));//0
            Console.WriteLine("value for feb is"+Convert.ToInt32(month.feb));//1
            Console.WriteLine("value for march is" + Convert.ToInt32(month.april));//2
        }
    }
}
