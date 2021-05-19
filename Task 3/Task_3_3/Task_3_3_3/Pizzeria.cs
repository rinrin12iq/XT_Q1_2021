using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Task_3_3_3
{
    public class Pizzeria
    {
        public List<Pizza> Menu;
        private TimeSpan baseCookingTime = TimeSpan.FromSeconds(10);
        private string _name;

        public Pizzeria(string name)
        {
            Name = name;
            Menu = new List<Pizza>();
            OnOrderReady += Notify;
        }

        public Pizzeria(string name, params Pizza[] pizzas)
        {
            Name = name;
            Menu = new List<Pizza>(pizzas);
            OnOrderReady += Notify;
        }

        public static event Action<Order> OnOrderReady = delegate {}; 

        public string Name
        {
            get => _name; 
            private set => _name = value;
        }

        public List<Pizza> PrepareOrder(Order order)
        {
            if (order.OrderedPizza.Any())
            {
                List<Pizza> pizza = new List<Pizza>();

                int index;

                foreach (string p in order.OrderedPizza)
                {
                    index = Menu.FindIndex(i => i.PizzaName == p);
                    pizza.Add(new Pizza(Menu[index].PizzaName, Menu[index].Price));
                }

                TimeSpan cookingTime = baseCookingTime + TimeSpan.FromSeconds(2 * order.OrderedPizza.Count);

                Thread.Sleep(cookingTime);

                OnOrderReady?.Invoke(order);

                return pizza;
            }

            return null;
        }

        static public void Notify(Order customerOrder)
        {
            Console.WriteLine($"Order {customerOrder.Number} is ready");
        }
    }
}
