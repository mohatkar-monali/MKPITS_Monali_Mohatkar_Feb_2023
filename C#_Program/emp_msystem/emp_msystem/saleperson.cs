using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emp_msystem
{
    internal class saleperson:Employee
    {
        public int bonus = 500;
        public override int calculateSallary(int amt)
        {
            sallary = sallary + bonus;
            return amt;
        }
    }
}
