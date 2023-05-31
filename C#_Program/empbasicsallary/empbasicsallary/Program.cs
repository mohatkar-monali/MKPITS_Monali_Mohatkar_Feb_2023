using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empbasicsallary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string employeename;
            int basicsallary,hra,da,totalsallary;
            long employeeno;
            Console.WriteLine("enetr  name");
            employeename = Console.ReadLine();
            Console.WriteLine("enetr number");
            employeeno=Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("enetr basicsallary");
            basicsallary = Convert.ToInt32(Console.ReadLine());
            hra = (basicsallary * 32) / 100;
            da = (basicsallary * 45) / 100;
            totalsallary = basicsallary + hra + da;
            Console.WriteLine("Name:" + employeename);
            Console.WriteLine("mobno:" + employeeno);
            Console.WriteLine("hra=" + hra);
            Console.WriteLine("da=" + da);
            Console.WriteLine("totalsallary="+totalsallary);
            Console.ReadLine();
        }
    }
}
