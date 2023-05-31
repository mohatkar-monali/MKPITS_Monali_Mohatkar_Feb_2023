using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singlelevelwith_overloading
{
    class person
    {
        public string name;
        public string address;
        public int age;
        public void getdata(string name, string address,int age)
        {
            this.name = name;
            this.address = address;
            this.age = age;
        }
        public void display()
        {
            Console.WriteLine("name=" + name);
            Console.WriteLine("address="+address);
            Console.WriteLine("age=" + age);
        }
    }
    class customer:person
    {
        public int custid;
        public void getdata(int custid,string name,string address,int age)//function overloading 
        {
            
            this.custid = custid;
            getdata(name,address,age);
        }
        public void display()//functiopn overriding
        {
            Console.WriteLine("custid=" + custid);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            customer cust = new customer();
            cust.getdata(123,"ram", "nagpur",23);
            cust.display();
        }
    }
}
