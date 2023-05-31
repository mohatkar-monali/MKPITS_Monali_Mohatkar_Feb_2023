using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace floatarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] array = new float[4];
            array[0] = 0.45f;
            array[1] = 7.89f;
            array[2] = 5.46f;
            array[3] = 3.456f;
            for(int num = 0;num<array.Length;num++)
            {
                Console.WriteLine("num="+array[num]);
            }
        }
    }
}
