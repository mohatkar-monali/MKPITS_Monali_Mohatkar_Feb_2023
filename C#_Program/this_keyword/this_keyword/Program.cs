using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace this_keyword
{
    class thiskey
    {
        int rollno;
        string name;
        public void getdata(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
        }
        public void display()
        {
            Console.WriteLine("rollno=" + rollno);
            Console.WriteLine("name=" + name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            thiskey key=new thiskey();
            Console.WriteLine("enter rollno");
            int rollno=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter name");
            string name = Console.ReadLine();
            key.getdata(rollno, name);
            key.display();
            Console.ReadLine();
        }
    }
}
