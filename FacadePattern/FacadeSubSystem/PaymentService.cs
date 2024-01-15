using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.FacadeSubSystem
{
    public class PaymentService
    {
        public void OrderPaid()
        {
            Console.WriteLine("Order paid ... Thank you");
        }
    }
}
