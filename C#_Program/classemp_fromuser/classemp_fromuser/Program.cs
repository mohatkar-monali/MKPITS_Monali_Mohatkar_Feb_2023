﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace classemp_fromuser
{
    internal class Program
    {
        class employee
        {
            int empid, sallary, mobilenumber;
            string empname, department, address;

            public void getdata(int id, int sal, int mobno, string name, string dep, string add)
            {
                empid = id; sallary = sal; mobilenumber = mobno;
                empname = name; department = dep; address = add;
            }
            public void showdata()
            {
                Console.WriteLine("empid=" + empid);
                Console.WriteLine("empsallary=" + sallary);
                Console.WriteLine("empmobileno=" + mobilenumber);
                Console.WriteLine("empname=" + empname);
                Console.WriteLine("empdepartment=" + department);
                Console.WriteLine("empaddress" + address);
            }
        }
        static void Main(string[] args)
        {
            employee emp = new employee();
            Console.WriteLine("enter emp id");
            int empid=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter sallary");
            int sallary=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter mobilenumber");
            int mobilenumber=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter name");
            string name=Console.ReadLine();
            Console.WriteLine("enter department");
            string department=Console.ReadLine();
            Console.WriteLine("enter address");
            string address=Console.ReadLine();

           
            emp.getdata( empid ,sallary,mobilenumber,name,department,address);
            emp.showdata();
            Console.ReadLine();
        }
    }
}
