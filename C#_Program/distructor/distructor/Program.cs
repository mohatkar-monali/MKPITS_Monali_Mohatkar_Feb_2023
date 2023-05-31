using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace distructor
{
    class employee
    {
        int empid;
        string empname;
        //creating distructor name ~employee
        ~employee()
        {
            Console.WriteLine("inside distructor");//use to cleanup operation
            //it will run after code exicute
        }
        public employee(int empid, string empname)
        {
            this.empid = empid;
            this.empname = empname;
        }
        public void dislpay()
        {
            Console.WriteLine("empid="+empid);
            Console.WriteLine("empname=" + empname);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            employee emp = new employee(123,"raj");
            emp.dislpay();
            Console.ReadLine();
        }
    }
}
