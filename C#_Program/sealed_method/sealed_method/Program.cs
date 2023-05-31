using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealed_method
{
    class Person
    {
        public virtual void display()
        {
            Console.WriteLine("Hello From Person Class");
        }
    }
    class Student : Person
    {
        //creating a sealed method
        public sealed override void display()//this method can not be override further
        {
            Console.WriteLine("Hello Form Student Class");
        }
    }
    class PastStdent : Student
    {
       
        public void show()
        {
            Console.WriteLine("Hello From PastStudent Class");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PastStdent st = new PastStdent();
           
            st.display();
            st.show();
        }
    }
}
