using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3._3._3
{
    class Customer
    {
        public string Name { get; set; }

        public void CustomerEvent()
        {
            Console.WriteLine($"Пицца для заказчика {Name} готова! Заберите свой заказ!");
        }
    }
}
