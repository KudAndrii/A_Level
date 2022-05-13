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
        public Order(IUser user, List<IProduct> products)
        {
            User = user;
            Products = products;
        }

        public IUser User { get; }
        public List<IProduct> Products { get; }
    }
}
