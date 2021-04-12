using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3._3._3
{
    class Pizza
    {
        public string PizzaName { get; set; }

        public int Price { get; set; }

        public Pizza (PizzaType type, int price)
        {
            switch (type)
            {
                case PizzaType.Margarita:
                    PizzaName = PizzaType.Margarita.ToString();
                    break;
                case PizzaType.Sicilian:
                    PizzaName = PizzaType.Sicilian.ToString();
                    break;
                case PizzaType.Diablo:
                    PizzaName = PizzaType.Diablo.ToString();
                    break;
                case PizzaType.Hawaiian:
                    PizzaName = PizzaType.Hawaiian.ToString();
                    break;
                case PizzaType.Calzone:
                    PizzaName = PizzaType.Calzone.ToString();
                    break;
                case PizzaType.Caprichosa:
                    PizzaName = PizzaType.Caprichosa.ToString();
                    break;
                case PizzaType.FourCheeses:
                    PizzaName = PizzaType.FourCheeses.ToString();
                    break;
            }

            Price = price;
        }
    }
}
