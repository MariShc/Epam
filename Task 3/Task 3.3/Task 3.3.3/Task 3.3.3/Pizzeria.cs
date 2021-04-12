using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3._3._3
{
    class Pizzeria
    {
        public event Action<Customer> OnCooked;

        public Order CookedPizza(PizzaType pizzaType, int price, Customer customer)
        {
            Order newOrder = new Order(new Pizza(pizzaType, price));
            OnCooked(customer);
            return newOrder;
        }
    }
}
