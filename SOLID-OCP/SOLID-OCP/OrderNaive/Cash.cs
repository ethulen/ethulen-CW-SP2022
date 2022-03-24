using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderNaive
{
    class Cash : IOrderMethod
    {
        public void Pay()
        {
            Console.WriteLine("Processing payment with Cash");
        }
    }
}
