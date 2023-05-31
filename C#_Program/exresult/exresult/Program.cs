using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exresult
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1,s2,s3,total;
            float percentage;
            string grade = "";
            Console.WriteLine("enter marks for subject1");
            s1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the marks for subject2 ");
            s2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the marks for subject3");
            s3=Convert.ToInt32(Console.ReadLine());
            total =s1+s2+s3;
            percentage = (total / 300.0f) * 100.0f;
            Console.WriteLine("total=" + total);
            Console.WriteLine("percentage=" + percentage);
            
            if (percentage >=75 ) 
            {
                grade = "distingtion";
            }
            else if (percentage>=60 && percentage < 75)
            {
                grade = "first";
            }
            else
            {
                grade = "fail";
            }
            Console.WriteLine("grade= " + grade);
            Console.ReadKey();
        }
    }
}
