using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empbonus_inheritance
{
    class employee
    {
        public float sallary=4000;
    }
    class programer:employee 
    {
        public float bonus = 1000;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            programer prg = new programer();
            Console.WriteLine(prg.sallary);
            Console.WriteLine(prg.bonus);

        }
    }
}
