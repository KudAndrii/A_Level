using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop
{
    internal interface IShopInterface
    {
        public void ShowProducts(in List<IProduct> products);
        public void ShowShoppingCart(in List<IProduct> shoppingCart);
        public IBuyer Ordering(List<IProduct> orderList);
    }
}
