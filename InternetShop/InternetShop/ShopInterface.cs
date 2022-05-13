using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop
{
    internal class ShopInterface : IShopInterface
    {
        public void ShowProducts(in List<IProduct> products)
        {
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name}\tPrice: {product.Price}\tDescription: {product.Description}");
            }
        }

        public void ShopMenu(in List<IProduct> productRange)
        {
            string input = string.Empty;
            Cart cart = new Cart();
            while (input.ToLower() != "order")
            {
                Console.WriteLine("*Range of products*");
                ShowProducts(productRange);
                Console.WriteLine("Write a name of product, which you wanna add to your cart.");
                Console.WriteLine("Write *show* - to see your shopping cart.");
                Console.WriteLine("Write *order* - to create the order.");
                Console.Write($"({cart.ShoppingCart?.Count})");
                input = Console.ReadLine();
                Console.Clear();
                foreach (var product in productRange)
                {
                    if (input.ToLower() == product.Name.ToLower())
                    {
                        new ShopService().AddProduct(product, ref cart);
                    }
                }

                if (input.ToLower() == "show")
                {
                    Console.WriteLine("*Shopping Cart*");
                    ShowProducts(cart.ShoppingCart);
                }
            }

            new ShopService().OrderFormation(cart.ShoppingCart);
        }

        public void OrderInfo(in Order order)
        {
            Console.Write($"Order number: {new Random().Next(1, 100)}");
            Console.WriteLine($"for {order.Buyer.Name} {order.Buyer.Surname} is ready to sending");
        }
    }
}
