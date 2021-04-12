using System;

namespace Task_3._3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { Name = "Masha" };
            Customer customer2 = new Customer() { Name = "Olga" };
            Customer customer3 = new Customer() { Name = "Andrei" };

            Pizzeria myPizzeria = new Pizzeria();

            myPizzeria.OnCooked += (customer) => customer.CustomerEvent();

            Order orderForCustomer1 = myPizzeria.CookedPizza(PizzaType.Margarita, 300, customer1);
            Order orderForCustomer2 = myPizzeria.CookedPizza(PizzaType.Sicilian, 280, customer2);
            Order orderForCustomer3 = myPizzeria.CookedPizza(PizzaType.FourCheeses, 350, customer3);
        }
    }
}
