using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop
{
    /// <summary>
    /// Class merge user and List of Iproduct into Order.
    /// </summary>
    internal class Order
    {
        public Order(User user, List<Product> products)
        {
            User = user;
            Products = products;
        }

        public User User { get; }
        public List<Product> Products { get; }
    }
}
