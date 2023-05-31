using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace funresult
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1, s2, s3;
            Console.WriteLine("enter subject1 marks");
            s1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter subject2 marks");
            s2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter subject3 marks");
            s3=Convert.ToInt32(Console.ReadLine());
            total(s1 , s2, s3);
     
            Console.ReadKey();
        }
        static int total(int n1,int n2,int n3) 
        {
            int result=n1+n2+n3;
            Console.WriteLine("total="+result);
            int per =n1+n2+n3*0.3;
            
            if (per >= 75)
            {
                Console.WriteLine("grade=distingtion");
            }
            else if (per >= 60 && per < 75)
            {
                Console.WriteLine("grade=first");
            }
            else
            {
                 Console.WriteLine("grade=fail");
            }
            return per;
        }
    }
}
