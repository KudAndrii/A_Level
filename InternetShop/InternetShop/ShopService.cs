using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop
{
    internal class ShopService : IShopService
    {
        public void AddProduct(IProduct product, ref Cart cart)
        {
            if (cart.ShoppingCart == null)
            {
                cart.ShoppingCart = new List<IProduct>(1);
                cart.ShoppingCart.Add(product);
            }
            else
            {
                cart.ShoppingCart.Add(product);
            }
        }

        public Order OrderFormation(List<IProduct> products)
        {
            User user = new User();
            Console.Write($"Enter your name: ");
            user.Name = Console.ReadLine();
            Console.Write($"Enter your surname: ");
            user.Surname = Console.ReadLine();
            Console.Write($"Enter your email: ");
            user.Email = Console.ReadLine();
            List<IProduct> resultingProducts = products;
            Order result = new Order(user, resultingProducts);
            products.Clear();
            ShopInterface shopInterface = new ShopInterface();
            shopInterface.OrderInfo(result);
            return result;
        }
    }
}
