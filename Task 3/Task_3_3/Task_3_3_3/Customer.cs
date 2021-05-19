using System.Collections.Generic;
using System.Linq;

namespace Task_3_3_3
{
    class Customer
    {
        private string _phoneNumber;
        private string _name;

        public Customer(string name, long phoneNumber)
        {
            Name = name;
            PhoneNumber = string.Format("{0:+7 (###) ###-##-##}", phoneNumber);
        }

        public string Name
        {
            get => _name;
            private set => _name = value;
        }

        public string PhoneNumber
        {
            get => _phoneNumber;
            private set => _phoneNumber = value;
        }

        public Order OrderPizza(Pizzeria pizzeria, params string[] pizzaNames)
        {
            Order customersOrder = new Order();

            foreach (string pizzaName in pizzaNames)
            {
                if (pizzeria.Menu.Any(i => i.PizzaName == pizzaName))
                {
                    customersOrder.OrderedPizza.Add(pizzaName);
                }
            }

            return customersOrder;
        }
    }
}
