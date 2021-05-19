using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_3_3_3
{
    public class Pizza
    {
        private string _pizzaName;
        private int _price;

        public Pizza(string pizzaName, int price)
        {
            PizzaName = pizzaName;
            Price = price;
        }

        public event Action<Pizza> OnReady = delegate { };

        public string PizzaName
        {
            get => _pizzaName; 
            private set => _pizzaName = value; 
        }

        public int Price
        {
            get => _price;
            set
            {
                if (value >= 0) 
                {
                    _price = value; 
                }
                else
                {
                    throw new ArgumentException("Цена не может быть отрицательным числом");
                }
            }
        }
    }
}
