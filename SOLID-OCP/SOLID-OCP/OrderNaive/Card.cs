using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderNaive
{
    class Card : IOrderMethod
    {
        public void Pay()
        {
            Console.WriteLine("Processing payment with Credit Card");
        }
    }
}
