using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop
{
    internal interface IShopInterface
    {
        /// <summary>
        /// Method outputs list of products to the console.
        /// </summary>
        /// <param name="products">Incoming list of products.</param>
        public void ShowProducts(in List<IProduct> products);

        /// <summary>
        /// Method provides a choise between choosing products, showing shoppingCart and odreding.
        /// </summary>
        /// <param name="productRange">Incoming range of products.</param>
        public void ShopMenu(in List<IProduct> productRange);

        /// <summary>
        /// Method outputs info about generated order.
        /// </summary>
        /// <param name="order">Incoming order.</param>
        public void OrderInfo(in Order order);
    }
}
