using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///initilizing array
            int[] arr = { 13, 12, 11 };
            int temp;//to swap numbers

            //outer counter for index
            for(int innercounter=0; innercounter<arr.Length; innercounter++)
            {
                //inner counter for (value at index)
                for(int outercounter=innercounter+1; outercounter<arr.Length; outercounter++)
                {
                    if (arr[innercounter] > arr[outercounter])
                    {
                        //to swap values in array
                        temp = arr[innercounter];
                        arr[innercounter] = arr[outercounter];
                        arr[outercounter]=temp;
                    }
                }
            }
            //to print sorted array
            for(int counter=0;counter<arr.Length; counter++)
            {
                Console.WriteLine(arr[counter]);
            }
            Console.ReadKey();
        }
    }
}
