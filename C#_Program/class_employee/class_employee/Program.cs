using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_employee
{
    class employee
    {
        int empid,sallary,empmob;
        string empname,departmaint,empaddress;
        public void getdata()
        {
            empid = 123;
            sallary = 45000;
            empmob = 234567890;
            empname = "shyam";
            departmaint = "RND";
            empaddress = "plotno 23,Wardha Road,Nagpur,Maharashtra,India";
        }
        public void displaydata()
        {
            Console.WriteLine("empid="+empid);
            Console.WriteLine("empsallary="+sallary);
            Console.WriteLine("empmobileno="+empmob);
            Console.WriteLine("empname="+empname);
            Console.WriteLine("department="+departmaint);
            Console.WriteLine("empaddress="+empaddress);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            employee emp1= new employee();
            emp1.getdata();
            emp1.displaydata();
            Console.ReadLine();
        }
    }
}
