using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resultusingarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int[] num=calculate();
            int[] num2 = new int[1];
            for(int i=0; i<3; i++)
            {
                Console.Write(num[i]+ "\t");
            }
            Console.WriteLine();
            for(int i=0 ; i<3 ; i++)
            {
               int sum=0;
                sum= sum+ num[i];
                Console.WriteLine("total=" + sum);

            }
            //Console.WriteLine("total=" + sum);
            Console.ReadLine();
        }
        static int[] calculate()
        {
            int[] subjects=new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("enetr marks");
                subjects[i] = Convert.ToInt32(Console.ReadLine());
               
            }
            return subjects;
        }

    }
}
