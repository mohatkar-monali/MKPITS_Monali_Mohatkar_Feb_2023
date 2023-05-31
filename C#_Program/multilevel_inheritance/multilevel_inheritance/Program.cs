using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multilevel_inheritance
{
    class animal
    {
        public void eat()
        {
            Console.WriteLine("Eating");
        }
    }
    class dog : animal
    {
        public void bark()
        {
            Console.WriteLine("barking");
        }

    }
    class babydog : dog
    {
        public void weep()
        {
            Console.WriteLine("weeping");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            babydog b = new babydog();
            b.eat();
            b.bark();
            b.weep();
        }
    }
}
