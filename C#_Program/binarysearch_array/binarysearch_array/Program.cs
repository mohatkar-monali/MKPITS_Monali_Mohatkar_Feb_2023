using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarysearch_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 4, 6, 8, 10, 12, 14, 16 };
            Console.WriteLine("enter number to search for");
            int target = Convert.ToInt32(Console.ReadLine());
            int result=binarysearch(arr, target);
            if (result == -1)
            {
                Console.WriteLine("the number{0} was not found ",target);
            }
            else
            {
                Console.WriteLine("the number {0} was  found at index of {1} ",target,result);
            }
            Console.ReadLine();
        }
        static int binarysearch(int[] arr,int target)
        {
            
            int left = 0;
            int right=arr.Length-1;
            while (left <= right)
            {
                int middle=(left+right)/2;
                if (arr[middle]==target) 
                {
                    return middle;
                }
                else if (arr[middle]<target)
                {
                    left= middle+1;
                }
                else
                {
                    left = middle-1;
                }
            }
            return -1;
        }
    }
}
