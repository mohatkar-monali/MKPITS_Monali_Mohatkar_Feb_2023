using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class Class1
    {
        int bal = 1000;
        public string Deposite(int amt)
        {
            bal=bal+amt;
            return "balance is"+bal.ToString();
        }
        public string Withdraw(int amt)
        {
            bal= bal-amt;
            return "balance is" + bal.ToString();
        }
    }
}
