namespace Task_3_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizzeria Dodo = new Pizzeria("Dodo Pizza", new Pizza("Margherita", 60)
                , new Pizza("Napoletana", 70), new Pizza("American", 50));

            Customer anonymous2015 = new Customer("Oleg", 9786347891);

            Order customersOrder = anonymous2015.OrderPizza(Dodo, "Margherita", "Napoletana");

            Dodo.PrepareOrder(customersOrder);
        }
    }
}
