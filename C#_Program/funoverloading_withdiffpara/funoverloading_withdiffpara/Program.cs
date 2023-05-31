using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funoverloading_withdiffpara
{
    class employee
    {
        int empid;
        string empname;
        public void getdata(int empid,string empname)
        {
            this.empid = empid;
            this.empname = empname;
        }
        public void getdata(string empname,int empid)
        {
            this.empname=empname;
            this.empid = empid;
        }
        public void display()
        {
            Console.WriteLine("empname=" + empname);
            Console.WriteLine("empid="+empid);
        } 
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            employee emp = new employee();
            emp.getdata(123, "raj");
            employee emp1 = new employee();
            emp1.getdata(345, "shyam");
            emp.display();
            emp1.display();
        }
    }
}
