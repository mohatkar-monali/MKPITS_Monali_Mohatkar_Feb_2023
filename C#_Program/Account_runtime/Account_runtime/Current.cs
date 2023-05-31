using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_runtime
{
    internal class Current:Account
    {
        public override int deposite(int amt)
        {
            bal = bal + amt;
            return bal;
        }
    }
}
