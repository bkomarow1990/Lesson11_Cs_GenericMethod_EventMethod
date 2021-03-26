using System;

namespace Lesson11CS_EventHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            Product pizza = new Product("Margharia", 120, 22);
            Console.WriteLine(pizza.ToString());
            Client ivan = new Client{Name = "Ivan"};
            pizza.PriceChanged += ivan.Handler;
            pizza.Price = 117;

        }
    }
}
