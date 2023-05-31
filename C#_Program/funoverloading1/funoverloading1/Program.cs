using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funoverloading1
{
    class employee
    {
        int empid;
        string name;
        public void getdata(int empid)
        {
            this.empid = empid;
            this.name = "raj";
        }
        public void getdata(int empid, string name)
        {
            this.empid = empid;
            this.name = name;
        }
        public void showdata()
        {
            Console.WriteLine("empid="+empid);
            Console.WriteLine("name=" + name);
        }
    }   
        internal class Program
        {
        static void Main(string[] args)
        {
            employee emp = new employee();
            emp.getdata(1);
            emp.showdata();
            employee emp1=new employee();
            emp1.getdata(1,"shyam");
        }
        }
}
