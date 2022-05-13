using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop
{
    internal class ShopService : IShopService
    {
        public void AddProduct(List<IProduct> productRange, ref Cart cart, string input)
        {
            if (cart.ShoppingCart == null)
            {
                cart.ShoppingCart = new List<IProduct>(1);
            }

            foreach (var product in productRange)
            {
                if (input.ToLower() == product.Name.ToLower())
                {
                    cart.ShoppingCart.Add(product);
                }
            }
        }

        public IUser Registration()
        {
            IUser user = new User();
            Console.Write($"Enter your name: ");
            user.Name = Console.ReadLine();
            Console.Write($"Enter your surname: ");
            user.Surname = Console.ReadLine();
            Console.Write($"Enter your email: ");
            user.Email = Console.ReadLine();
            return user;
        }

        public Order OrderFormation(List<IProduct> products, IUser user = null)
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
