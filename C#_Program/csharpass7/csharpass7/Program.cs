using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpass7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name1,name2;
            Console.WriteLine("enter string ");
            name1= Console.ReadLine();
            Console.WriteLine("enetr string");
            name2= Console.ReadLine();
            string show = check_anagrams(name1, name2);
        }
        static string check_anagrams(string name1,string name2) 
        {

            Boolean isalagram = false;           
             for(int counter1=0,counter2=0; counter1<name1.Length; counter1++) 
             { 
                if (name1[counter1]==name2[counter2]) 
                { 
                    isalagram=true;
                    break;
                }
             }
             if(isalagram==true) 
             {
                Console.WriteLine("entered string is an alagram");  
             }
            else
            {
                Console.WriteLine("enetrd string is not an alagram");
            }
            return name1; 
        }
    }
}
