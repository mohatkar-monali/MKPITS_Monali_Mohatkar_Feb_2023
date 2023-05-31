using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classprogramer
{
    class employee
    {
        public float sallary = 4000;
    }
    class programer : employee
    {
        public float salary;
        public float bonus;
        public void getdata(float salary,float bonus)
        {
            this.salary = salary;
            this.bonus = bonus;
        }
        public void displaydata()
        {
            Console.WriteLine("salary=" + salary);
            Console.WriteLine(" bonus="+bonus);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            programer prg = new programer();
            Console.WriteLine(prg.salary);
            prg.getdata(12000, 1000);
            prg.displaydata();
        }
    }
}
