using System;
namespace program
{
    class program 
    {
        static void Main()
        {
            int num, square;
            Console.WriteLine("enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            square = num * num;
            Console.WriteLine("square is"+square);
            Console.ReadKey();
        }
    }
}
