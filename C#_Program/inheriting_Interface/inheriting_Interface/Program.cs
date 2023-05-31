using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheriting_Interface
{
    internal class Program
    {
        //creating interface IAccount
        interface IAccount
        {
            string deposite(int amt);
        }
        //creating  abstract baseclass Account and implimentig interface IAccount
       abstract class Account : IAccount
        {
            public int balance = 1000;
            //creating abstract method
            public abstract string deposite(int amt);
            public string showbal() 
            {
                return "bal is" + balance;
            }
        }
        //creating derived class Saving 
        class Saving : Account
        {
            public int intrest = 500;
            public override string deposite(int amt)
            {
                balance = balance + amt + intrest;
                return "deposite bal is" + balance;
            }
        }
        //creating derived class current
        class Current : Account
        {
            public override string deposite(int amt)
            {
                balance= balance + amt;
                return "deposited balance is" + balance;
            }
        }
        static void Main(string[] args)
        {
            int amount;
            Console.WriteLine("enter amount");
            amount= Convert.ToInt32(Console.ReadLine());
            string acttype;
            Console.WriteLine("enter account type");
            acttype = Console.ReadLine();
          //
            Account act = null;
            if(acttype == "saving")
            {
                act = new Saving();
            }
            else if (acttype == "Current")
            {
                act = new Current();
            }
            
            string res=act.deposite(amount);
            Console.WriteLine(res);
            Console.WriteLine(act.showbal());
        }
    }
}
