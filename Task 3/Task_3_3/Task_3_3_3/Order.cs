using System;
using System.Collections.Generic;

namespace Task_3_3_3
{
    public class Order
    {
        public List<string> OrderedPizza;

        public Order()
        {
            Number = Guid.NewGuid();
            OrderedPizza = new List<string>();
        }

        public Guid Number { get; }
    }
}