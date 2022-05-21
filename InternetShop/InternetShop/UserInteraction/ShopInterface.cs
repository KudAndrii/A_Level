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
            ShopService shopService = new ShopService();
            OrderFormation orderFormation = new OrderFormation();
            ShopInfo shopInfo = new ShopInfo();
            User user = null;
            while (true)
            {
                ShowProducts(productRange, "*Range of products*");
                shopInfo.ShopMenuInfo(orderFormation.ShoppingCart);
                input = Console.ReadLine();
                Console.Clear();
                shopService.AddProduct(productRange, orderFormation, input);
                switch (input.ToLower())
                {
                    case "order":
                        if (orderFormation.ShoppingCart == null || orderFormation.ShoppingCart.Count == 0)
                        {
                            ShowProducts(orderFormation.ShoppingCart, "*Shopping Cart*");
                        }
                        else if (user == null)
                        {
                            orderFormation.Ordering(orderFormation.ShoppingCart);
                        }
                        else
                        {
                            orderFormation.Ordering(orderFormation.ShoppingCart, user);
                        }

                        break;
                    case "show":
                        ShowProducts(orderFormation.ShoppingCart, "*Shopping Cart*");
                        break;
                    case "sign in":
                        if (user == null)
                        {
                            user = shopService.Registration();
                        }
                        else
                        {
                            Console.WriteLine("You are already registered.");
                        }

                        break;
                }
            }
        }
    }
}
