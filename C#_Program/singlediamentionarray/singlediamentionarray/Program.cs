using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singlediamentionarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array=new int[5];
            for(int i=0; i<5; i++)
            {
                Console.WriteLine("enter number");
                array[i]=Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0; i<5; i++)
            {
                Console.Write(array[i]+"\t");
            }
            Console.WriteLine();
        }
    }
}
