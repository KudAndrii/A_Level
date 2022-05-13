using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop
{
    internal class ShopInterface : IShopInterface
    {
        public void ShowProducts(in List<IProduct> products, string header)
        {
            if (products == null || products.Count == 0)
            {
                Console.WriteLine(header);
                Console.WriteLine("Your cart is empty now.");
            }
            else
            {
                Console.WriteLine(header);
                foreach (var product in products)
                {
                    Console.WriteLine($"{product.Name}\tPrice: {product.Price}\tDescription: {product.Description}");
                }
            }
        }

        public void ShopMenu(in List<IProduct> productRange)
        {
            string input = string.Empty;
            Cart cart = new Cart();
            ShopService shopService = new ShopService();
            IUser user = null;
            while (true)
            {
                ShowProducts(productRange, "*Range of products*");
                ShopMenuInfo(cart);
                input = Console.ReadLine();
                Console.Clear();
                shopService.AddProduct(productRange, ref cart, input);
                switch (input.ToLower())
                {
                    case "order":
                        if (cart.ShoppingCart == null || cart.ShoppingCart.Count == 0)
                        {
                            ShowProducts(cart.ShoppingCart, "*Shopping Cart*");
                        }
                        else if (user == null)
                        {
                            shopService.OrderFormation(cart.ShoppingCart);
                        }
                        else
                        {
                            shopService.OrderFormation(cart.ShoppingCart, user);
                        }

                        break;
                    case "show":
                        ShowProducts(cart.ShoppingCart, "*Shopping Cart*");
                        break;
                    case "sign in":
                        user = shopService.Registration();
                        break;
                }
            }
        }

        public void ShopMenuInfo(in Cart cart)
        {
            Console.WriteLine("Write a name of product, which you wanna add to your cart.");
            Console.WriteLine("Write *show* - to see your shopping cart.");
            Console.WriteLine("Write *order* - to create the order.");
            Console.WriteLine("Write *sign in* - to register your account.");
            Console.Write($"({cart.ShoppingCart?.Count})");
        }

        public void OrderInfo(in Order order)
        {
            Console.Write($"Order number: {new Random().Next(1, 100)}");
            Console.WriteLine($" for {order.User.Name} {order.User.Surname} is ready to be sent.");
        }
    }
}
