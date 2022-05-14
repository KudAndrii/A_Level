using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop
{
    internal class ShopInterface
    {
        /// <summary>
        /// Method outputs list of products to the console.
        /// </summary>
        /// <param name="products">Incoming list of products.</param>
        /// <param name="header">Info about incoming products.</param>
        public void ShowProducts(in List<Product> products, string header)
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

        /// <summary>
        /// Method provides a choise between choosing products, showing shoppingCart and odreding.
        /// </summary>
        /// <param name="productRange">Incoming range of products.</param>
        public void ShopMenu(in List<Product> productRange)
        {
            string input = string.Empty;
            Cart cart = new Cart();
            ShopService shopService = new ShopService();
            User user = null;
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

        /// <summary>
        /// Output service info about menu.
        /// </summary>
        /// <param name="cart">Used to get count of products in the cart.</param>
        public void ShopMenuInfo(in Cart cart)
        {
            Console.WriteLine("Write a name of product, which you wanna add to your cart.");
            Console.WriteLine("Write *show* - to see your shopping cart.");
            Console.WriteLine("Write *order* - to create the order.");
            Console.WriteLine("Write *sign in* - to register your account.");
            Console.Write($"({cart.ShoppingCart?.Count})");
        }

        /// <summary>
        /// Method outputs info about generated order.
        /// </summary>
        /// <param name="order">Incoming order.</param>
        public void OrderInfo(in Order order)
        {
            Console.Write($"Order number: {new Random().Next(1, 100)}");
            Console.WriteLine($" for {order.User.Name} {order.User.Surname} is ready to be sent.");
        }
    }
}
