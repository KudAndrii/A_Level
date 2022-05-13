using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop
{
    internal interface IShopService
    {
        /// <summary>
        /// Method adding products to incoming cart if input == name of some product of productRange.
        /// </summary>
        /// <param name="productRange">Incoming list of range of products.</param>
        /// <param name="cart">Incoming list of products in cart.</param>
        /// <param name="input">Incoming string to comparison.</param>
        public void AddProduct(List<IProduct> productRange, ref Cart cart, string input);

        /// <summary>
        /// Create new account for order.
        /// </summary>
        /// <returns>New account for user.</returns>
        public IUser Registration();

        /// <summary>
        /// Method generating order.
        /// </summary>
        /// <param name="products">Incoming list of products, which whould be buyed.</param>
        /// <param name="user">Incoming user for merge to order (optional).</param>
        /// <returns>New Order.</returns>
        public Order OrderFormation(List<IProduct> products, IUser user = null);
    }
}
