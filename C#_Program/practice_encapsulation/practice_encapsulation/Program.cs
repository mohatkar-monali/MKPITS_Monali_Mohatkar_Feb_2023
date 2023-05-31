using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            employee emp = new employee();
            int res = emp.empid;
            string res1 = emp.empname;
            Console.WriteLine(res);
            Console.WriteLine(res1);
        }
        class employee
        {
            private int id;
            private string name;
            public int empid
            {
                get { return id; }
                set { id = value; }
            }
            public string empname
            {
                get { return name; }
                set { name = value; }
            }
        }
}
