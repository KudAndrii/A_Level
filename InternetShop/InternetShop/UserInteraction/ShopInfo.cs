using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop
{
    internal class ShopInfo
    {
        /// <summary>
        /// Output service info about menu.
        /// </summary>
        /// <param name="shoppingCart">Used to get count of products in the cart.</param>
        public void ShopMenuInfo(in List<Product> shoppingCart)
        {
            Console.WriteLine("Write a name of product, which you wanna add to your cart.");
            Console.WriteLine("Write *show* - to see your shopping cart.");
            Console.WriteLine("Write *order* - to create the order.");
            Console.WriteLine("Write *sign in* - to register your account.");
            Console.Write($"({shoppingCart?.Count})");
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
