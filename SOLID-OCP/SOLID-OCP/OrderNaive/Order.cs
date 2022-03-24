using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderNaive
{
    class Order
    {
        private int id;
        private string name;
        private double amount;
        private bool paid;

        public Order(int id, String name, double amount)
        {
            this.id = id;
            this.name = name;
            this.amount = amount;
            paid = false;
        }

        public void ProcessOrder(IOrderMethod method)
        {
            method.Pay();

            // 2 - If enough funds, mark order as paid
            paid = true;
        }

    }
}
