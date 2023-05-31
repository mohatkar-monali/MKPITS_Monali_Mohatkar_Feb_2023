using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productrate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string productname;
            int productrate,productquantity,totalamount,tax;
            Console.WriteLine("enetr product name");
            productname = Console.ReadLine();
            Console.WriteLine("enetr productrate");
            productrate=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enetr quantity");
            productquantity = Convert.ToInt32(Console.ReadLine());  
            totalamount=productrate*productquantity;
            Console.WriteLine("totalamount=" + totalamount);
            if (totalamount >= 10000)
            {
                tax = (18 * totalamount) / 100;
            }
            else if ((totalamount >= 5000) && (totalamount < 1000))
            {
                tax = (12 * totalamount) / 100;
            }
            else if (totalamount < 500)
            {
                tax = (5 * totalamount) / 100;
            }
            else 
            {
                tax = 0;
            }
            Console.WriteLine("tax is" + tax);
            Console.ReadLine();
        }
    }
}
