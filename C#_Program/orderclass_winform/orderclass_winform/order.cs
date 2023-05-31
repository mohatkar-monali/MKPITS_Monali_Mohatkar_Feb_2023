using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace orderclass_winform
{
    internal class order
    {
        int quantity;
        int productrate;
        int result = 0;
        public void calculate(int quantity,int prductrate)
        {
            this.quantity = quantity;
            this.productrate = prductrate;
            result = quantity * productrate;
        }
      
    }
}
