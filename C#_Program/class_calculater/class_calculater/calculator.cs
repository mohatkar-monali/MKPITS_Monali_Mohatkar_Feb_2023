using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_calculater
{
    class calculator
    {
        int prevnum;
        char op;
        int result = 0;
        public int plusclick(int prevnum)
        {
            this.prevnum = prevnum;
            op = '+';
            return op;
        }
        public int minusclick(int prevnum)
        {
            this.prevnum = prevnum;
            op = '-';
            return op;
        }
        public int calculateresult(int num)
        {
            switch(op)
            {
                case '+':
                    result = prevnum+num;
                    break;
                case '-':
                    result = prevnum-num;
                    break;
            }
            return result;
        }
    }
    
}
