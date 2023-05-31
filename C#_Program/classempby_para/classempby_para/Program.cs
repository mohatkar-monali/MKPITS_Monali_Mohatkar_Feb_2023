using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classempby_para
{
    class employee
    {
        int empid,sallary,mobilenumber;
        string empname, department, address;
        public void getdata(int id,int sal,int mobno,string name,string dep,string add)
        {
            empid = id;sallary=sal;mobilenumber=mobno;
            empname = name; department = dep;address=add;
        }
        public void displaydata()
        {
            Console.WriteLine("empid=" + empid);
            Console.WriteLine("empsallary="+sallary);
            Console.WriteLine("empmobileno="+mobilenumber);
            Console.WriteLine("empname="+empname); 
            Console.WriteLine("empdepartment="+department);
            Console.WriteLine("empaddress"+address);
         

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            employee emp = new employee();
            emp.getdata(122, 4500, 34567895, "jhon", "rnd", "at pot vvjjbhvdkkjdgcvh");
            emp.displaydata();
            Console.ReadKey();
        }
    }
}
