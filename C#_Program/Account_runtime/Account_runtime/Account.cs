using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_runtime
{
    internal class Account
    {
        public int bal = 1000;
        public virtual int deposite(int amt)
        {

            return bal; 
        }
    }
}
