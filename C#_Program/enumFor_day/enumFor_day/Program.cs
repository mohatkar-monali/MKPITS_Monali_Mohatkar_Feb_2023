using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumFor_day
{
    //creating enum for day
    enum day
    {
        day1=0,day2=day1+1,day3=day2+1,day4=day3+1
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("value for day1 is" + day.day1);//0
            Console.WriteLine("value for day2 is" + day.day2);//1
            Console.WriteLine("v alue for day3 is" + day.day3);//3
            Console.WriteLine("value for day4 is"+day.day4);//4
        }
    }
}
