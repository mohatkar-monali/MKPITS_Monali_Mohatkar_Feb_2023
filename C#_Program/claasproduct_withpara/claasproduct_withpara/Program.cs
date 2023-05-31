using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claasproduct_withpara
{
    class product
    {
        int prdid, quantity, prize;
        string prdname, quality, brand;
        public void getdata(int id,int qua,int pr,string name,string qual,string br)
        {
            prdid = id;
            quantity = qua;
            prdname= name;
            prize = pr;
            quality = qual;
            brand = br;

        }
        public void showdata()
        {
            Console.WriteLine("prdid=" + prdid);
            Console.WriteLine("quantity=" + quantity);
            Console.WriteLine("prdname=" + prdname);
            Console.WriteLine("prize="+prize);
            Console.WriteLine("quality=" + quality);
            Console.WriteLine("brand=" + brand);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            product prd = new product();
            prd.getdata(123, 2,5000, "watch", "good", "fastrack");
            prd.showdata();
            Console.ReadLine();
        }
    }
}
