using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classperson_inheritemp
{
    class person
    {
       public string name;
       public string address;
    }
    class employee:person
    {
       public int empno;
       public  int sallary;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            employee emp= new employee();
            emp.name = "ram";
            emp.address = "nagpur";
            emp.empno = 12;
            emp.sallary = 15000;
            Console.WriteLine( "name="+emp.name );
            Console.WriteLine( "address="+emp.address );
            Console.WriteLine( "empno="+emp.empno );
            Console.WriteLine( "sallary="+emp.sallary );
    }   }
}
