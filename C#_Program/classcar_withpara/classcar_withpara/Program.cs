using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classcar_withpara
{
    class car
    {
        int model;
        string carname;
        public void getdata(int m,string c)
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
            c1.getdata(123, "maruti");
            c1.showdata();
            Console.ReadLine();
        }
    }
}
