using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exofcount_static
{
    class Account
    {
        public int accno;
        public string name;
        //declaring feild as static
        public static int count;
        public Account(int accno, string name)
        {
            this.accno = accno;
            this.name = name;
            count++;
        }
        public void display()
        {
            Console.WriteLine("Account No.=" + accno);
            Console.WriteLine("Name=" + name);
        
        }

    }
  
    internal class Program
    {
        static void Main(string[] args)
        {
            Account act1 = new Account(123, "Manish");
            Account act2 = new Account(23, "Ram");
            act1.display();
            act2.display();
            Console.WriteLine("NO of Object="+Account.count);
        }
    }
}
