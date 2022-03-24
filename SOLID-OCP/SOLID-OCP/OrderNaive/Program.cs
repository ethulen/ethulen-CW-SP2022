using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderNaive
{
    class Program
    {
        static void Main(string[] args)
        {
                Order anOrder = new Order(1, "Headphones", 35.99);

                Console.WriteLine("*** O C P ***");
                Console.WriteLine();
                Console.WriteLine("  Select Method of Payment");
                Console.WriteLine("  1- Cash");
                Console.WriteLine("  2- Credit Card");
                int op = Convert.ToInt32(Console.ReadLine());

                IOrderMethod io;
                switch (op)
                {
                    case 1:
                        io = new Cash();
                        io.Pay();
                        break;
                    case 2:
                        io = new Card();
                        io.Pay();
                        break;
                    default:
                        io = new PaymentFailed();
                        io.Pay();
                        break;
                }

            anOrder.ProcessOrder(io);

                Console.ReadLine();
        }
    }
}
