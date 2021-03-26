using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson11CS_EventHandler
{
    class ProductArgs : EventArgs { 
        public double OldPrice { get; set; }
    }
    class Product
    {
        public event EventHandler<ProductArgs> PriceChanged;
        public string Name { get; set; }
        double price;
        public double Price
        {
            get => price;
            set
            {
                if (value < 0)
                {
                    return;
                }
                if (price!= value)
                {
                    double old = price;
                    price = value;
                    PriceChanged?.Invoke(this, new ProductArgs { OldPrice = old});
                   
                }
                
            }
        }
        public ushort Count { get; set; }
        public Product(string name, double price,ushort count)
        {
            Name = name;
            Price = price;
            Count = count;
        }
        public Product()
        :this("NoName",0,0){
            
        }
        public override string ToString()
        {
            return $"Product: {Name,-10}, Price: {Price,-12}, Count:{Count,-8}"; 
        }
    }
}
