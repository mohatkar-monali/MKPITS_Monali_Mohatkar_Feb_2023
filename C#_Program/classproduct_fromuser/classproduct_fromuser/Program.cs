using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace classproduct_fromuser
{
    class product
    {
        int prdid, quantity, prize;
        string prdname, quality, brand;
        public void getdata(int id, int qua, int pr, string name, string qual, string br)
        {
            prdid = id;
            quantity = qua;
            prdname = name;
            prize = pr;
            quality = qual;
            brand = br;
        }
        public void showdata()
        {
            Console.WriteLine("prdid=" + prdid);
            Console.WriteLine("quantity=" + quantity);
            Console.WriteLine("prdname=" + prdname);
            Console.WriteLine("prize=" + prize);
            Console.WriteLine("quality=" + quality);
            Console.WriteLine("brand=" + brand);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            product prd = new product();
            Console.WriteLine("enter product id");
            int prdid=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter quantity");
            int quantity=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter prize");
            int prize=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter name");
            string prdname=Convert.ToString(Console.ReadLine());
            Console.WriteLine("enter quality");
            string quality=Convert.ToString(Console.ReadLine());
            Console.WriteLine("enter brand name");
            string brand=Convert.ToString(Console.ReadLine());
            prd.getdata(prdid, quantity, prize, prdname, quality, brand);
            prd.showdata();
            Console.ReadLine();
        }
    }
}
