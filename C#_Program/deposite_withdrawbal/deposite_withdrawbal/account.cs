using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deposite_withdrawbal
{
    internal class account
    {
        int accountno;
        int balance = 1000;

        public int deposite(int num)
        {
          
             num= Convert.ToInt32(num); 
             balance=balance+ num;
             return balance;
        }
        public int withdraw(int num)
        {
            
            num = Convert.ToInt32(num);
            balance = balance - num;
            return balance;
        }
    }
}
