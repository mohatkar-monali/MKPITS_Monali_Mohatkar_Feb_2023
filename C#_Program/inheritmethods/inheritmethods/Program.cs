using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritmethods
{
    class person
    {
        public string name;
        public string address;
        public void getpersondata(string name,string address)
        {
            this.name = name;
            this.address = address;
        }
        public void showpersondata()
        {
            Console.WriteLine("name=" + name);
            Console.WriteLine("address="+address);
        }

    }
    class employee : person
    {
        public int empno;
        public int empsallary;
        public void getemployeedata(int empno,int empsallary)
        {
            this.empno = empno;
            this.empsallary = empsallary;
        }
        public void showemployeedata()
        {
            Console.WriteLine("empno=" + empno);
            Console.WriteLine("empsaallary=" + empsallary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            employee emp= new employee();
            emp.getpersondata ("shyam","nagpur");
            emp.getemployeedata(123,15000);
            emp.showpersondata();
            emp.showemployeedata();
            
        }
    }
}
