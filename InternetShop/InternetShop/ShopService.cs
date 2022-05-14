using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop
{
    internal class ShopService
    {
        /// <summary>
        /// Method adding products to incoming cart if input == name of some product of productRange.
        /// </summary>
        /// <param name="productRange">Incoming list of range of products.</param>
        /// <param name="cart">Incoming list of products in cart.</param>
        /// <param name="input">Incoming string to comparison.</param>
        public void AddProduct(List<Product> productRange, ref Cart cart, string input)
        {
            if (cart.ShoppingCart == null)
            {
                cart.ShoppingCart = new List<Product>(1);
            }

            foreach (var product in productRange)
            {
                if (input.ToLower() == product.Name.ToLower())
                {
                    cart.ShoppingCart.Add(product);
                }
            }
        }

        /// <summary>
        /// Create new account for order.
        /// </summary>
        /// <returns>New account for user.</returns>
        public User Registration()
        {
            User user = new User();
            Console.Write($"Enter your name: ");
            user.Name = Console.ReadLine();
            Console.Write($"Enter your surname: ");
            user.Surname = Console.ReadLine();
            Console.Write($"Enter your email: ");
            user.Email = Console.ReadLine();
            return user;
        }

        /// <summary>
        /// Method generating order.
        /// </summary>
        /// <param name="products">Incoming list of products, which whould be buyed.</param>
        /// <param name="user">Incoming user for merge to order (optional).</param>
        /// <returns>New Order.</returns>
        public Order OrderFormation(List<Product> products, User user = null)
        {
            if (user == null)
            {
                user = Registration();
            }

            Order result = new Order(user, products);
            products.Clear();
            new ShopInterface().OrderInfo(result);
            return result;
        }
    }
}
