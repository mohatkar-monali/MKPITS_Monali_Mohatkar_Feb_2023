using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_product
{
    class product
    {
        int prdid,quantity,prize;
        string prdname, quality,brand;
        public void getdata()
        {
            prdid = 123;
            quantity = 2;
            prize = 4000;
            prdname = "watch";
            quality = "good";
            brand = "Fastrack";
        }
        public void showdata()
        {
            Console.WriteLine("prdid=" + prdid);
            Console.WriteLine("quantity=" + quantity);
            Console.WriteLine("prdname=" + prdname);
            Console.WriteLine("quality=" + quality);
            Console.WriteLine("brand=" + brand);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            product prd = new product();
            prd.getdata();
            prd.showdata();
            Console.ReadLine();
        }
    }
}
