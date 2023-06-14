using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public string Addition(int num1,int num2)
        {
            int result=num1+ num2;
            return "addition is" + result.ToString();
        }
        public string Substraction(int num1, int num2)
        {
            int result = num1 - num2;
            return "substraction is" + result.ToString();
        }
        public string Multiplition(int num1, int num2)
        {
            int result = num1 * num2;
            return "multiplication is" + result.ToString();
        }
        public string Division(int num1, int num2)
        {
            int result = num1 / num2;
            return "division is" + result.ToString();
        }
    }
}
