using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop
{
    internal class OrderFormation
    {
        public List<Product> ShoppingCart { get; set; }

        /// <summary>
        /// Method generating order.
        /// </summary>
        /// <param name="products">Incoming list of products, which whould be buyed.</param>
        /// <param name="user">Incoming user for merge to order (optional).</param>
        /// <returns>New Order.</returns>
        public Order Ordering(List<Product> products, User user = null)
        {
            if (user == null)
            {
                user = new ShopService().Registration();
            }

            Order result = new Order(user, products);
            products.Clear();
            new ShopInfo().OrderInfo(result);
            return result;
        }
    }
}
