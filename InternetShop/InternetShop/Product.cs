using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop
{
    internal class Product : IProduct
    {
        public Product(int price, string name, string description)
        {
            Price = price;
            Name = name;
            Description = description;
        }

        public int Price { get; }

        public string Name { get; }

        public string Description { get; }
    }
}
