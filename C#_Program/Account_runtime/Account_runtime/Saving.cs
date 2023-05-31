using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_runtime
{
    internal class Saving:Account
    {
        public int intrest = 500;
        public override int deposite(int amt)
        {
            bal=bal+amt+intrest;
            return  bal;
        }
    }
}
