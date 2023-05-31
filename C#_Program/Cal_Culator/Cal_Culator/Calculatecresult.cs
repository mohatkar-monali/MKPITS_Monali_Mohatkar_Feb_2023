using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_Culator
{
    internal class Calculatecresult
    {
        int prevnum;
        char op;
        int num;
        int result = 0;
        public char clickplus(int prevnum)
        {
            this.prevnum = prevnum;
            op = '+';
            return op;
        }
        public char clickminus(int prevnum)
        {
            this.prevnum = prevnum;
            op = '-';
            return op;
        }
        public char clickmultiply(int prevnum)
        {
            this.prevnum = prevnum;
            op = '*';
            return op;
        }
        public char clickdivision(int prevnum)
        {
            this.prevnum = prevnum;
            op = '/';
            return op;
        }
        public int calresult(int num) 
        {
            switch (op)
            {
                case '+':
                    result=prevnum+num; 
                    break;
                case '-':
                    result=prevnum-num;
                    break;
                case '*':
                    result=prevnum*num;
                    break;
                case '/':
                    result = prevnum /num;
                    break;
            }
            return result;
        }
    }
}
