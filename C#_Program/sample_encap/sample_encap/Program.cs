using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_encap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            employee emp = new employee();
            emp.empid = 1;
            int res = emp.empid;
            emp.empname = "Test";
            string res1 = emp.empname;
            Console.WriteLine(res);
            Console.WriteLine(res1);
            Console.ReadLine();
        }
                class employee
                {
                    public int empid
                    {
                        get;
                        set;
                    }
                    public string empname
                    {
                             get; 
                        set ;
                    }
                }
            }

     }
    
