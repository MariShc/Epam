using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3._3._3
{
    class Order
    {
        public int NumberOrder { get; }

        public Pizza Pizza { get; private set; }

        public Order (Pizza pizza) 
        {
            Pizza = pizza;
        }
    }
}
