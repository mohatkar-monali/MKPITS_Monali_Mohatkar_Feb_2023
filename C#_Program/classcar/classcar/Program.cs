using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classcar
{
    class car
    {
        int model;
        string carname;
        public void getdata()
        {
            model= 123;
            carname = "maruti";
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
            car car1 = new car();
            car1.getdata();
            car1.showdata();
            Console.ReadLine();
        }
    }
}
