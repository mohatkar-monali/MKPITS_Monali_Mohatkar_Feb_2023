using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classcar_fromuser
{
    class car
    {
        int model;
        string carname;
        public void getdata(int m, string c)
        {
            model = m;
            carname = c;
        }
        public void showdata()
        {
            Console.WriteLine("model=" + model);
            Console.WriteLine("carname=" + carname);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            car c1 = new car();
            Console.WriteLine("enter car model");
            int model=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter car name");
            string name=Console.ReadLine(); 
            c1.getdata(model, name);
            c1.showdata();
            Console.ReadLine();
        }
    }
}
