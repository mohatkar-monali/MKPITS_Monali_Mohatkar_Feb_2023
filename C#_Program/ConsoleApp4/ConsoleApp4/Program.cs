using System;
namespace program
{
    class program
    {
        static void Main()
        {
            int num1, num2,add;
            Console.WriteLine("enter the num1");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the num2");
            num2=Convert.ToInt32(Console.ReadLine());
            add=num1 + num2;
            Console.WriteLine("addition is"+add);
            Console.ReadKey();
        }
    }
}