using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson11CS_EventHandler
{
    class Client
    {
        public string Name { get; set; }
        public void Handler(object sender, ProductArgs e) {
            Product product = sender as Product;
            if (product != null)
            {
                Console.WriteLine($"Customer {Name} has notified about change price of {product.Name}/ New price {product.Price}, Old Price: {e.OldPrice}");
            }

        }
    }
}
