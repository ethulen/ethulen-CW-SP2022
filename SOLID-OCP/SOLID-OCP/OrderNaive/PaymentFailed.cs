using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderNaive
{
    class PaymentFailed : IOrderMethod
    {
        public void Pay()
        {
            Console.WriteLine("Payment Method Not Accepted");
        }
    }
}
