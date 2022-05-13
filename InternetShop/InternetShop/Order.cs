using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop
{
    internal class Order
    {
        public Order(IUser buyer, List<IProduct> products)
        {
            Buyer = buyer;
            Products = products;
        }

        public IUser Buyer { get; }
        public List<IProduct> Products { get; }
    }
}
