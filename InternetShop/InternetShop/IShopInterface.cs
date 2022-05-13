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
        /// <param name="header">Info about incoming products.</param>
        public void ShowProducts(in List<IProduct> products, string header);

        /// <summary>
        /// Method provides a choise between choosing products, showing shoppingCart and odreding.
        /// </summary>
        /// <param name="productRange">Incoming range of products.</param>
        public void ShopMenu(in List<IProduct> productRange);

        /// <summary>
        /// Output service info about menu.
        /// </summary>
        /// <param name="cart">Used to get count of products in the cart.</param>
        public void ShopMenuInfo(in Cart cart);

        /// <summary>
        /// Method outputs info about generated order.
        /// </summary>
        /// <param name="order">Incoming order.</param>
        public void OrderInfo(in Order order);
    }
}
