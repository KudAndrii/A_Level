using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop
{
    internal class ShopService : IShopService
    {
        public List<IProduct> ShoppingCart { get; private set; }

        public void AddProduct(List<IProduct> products)
        {
            string input = Console.ReadLine();
            foreach (var product in products)
            {
                if (input.ToLower() == product.Name.ToLower())
                {
                    ShoppingCart.Add(product);
                }
            }
        }

        public Order OrderFormation(List<IProduct> products)
        {
            IBuyer buyer = new Buyer();
            Console.WriteLine("TO buy this products you should be registered.");
            Console.WriteLine($"Enter your name: {buyer.Name = Console.ReadLine()}");
            Console.WriteLine($"Enter your surname: {buyer.Surname = Console.ReadLine()}");
            Console.WriteLine($"Enter your email: {buyer.Email = Console.ReadLine()}");
            int finalPrice = 0;
            foreach (var product in products)
            {
                finalPrice += product.Price;
            }

            var resultingList = products;
            products.Clear();
            return new Order(buyer, resultingList, finalPrice);
        }
    }
}
