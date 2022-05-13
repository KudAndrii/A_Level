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
        /// Method adding products to incoming list of products.
        /// </summary>
        /// <param name="product">Incoming list of product range.</param>
        /// <param name="cart">Incoming list of products in cart.</param>
        public void AddProduct(IProduct product, ref Cart cart);

        /// <summary>
        /// Method generating order.
        /// </summary>
        /// <param name="products">Incoming list of products, which whould be buyed.</param>
        /// <returns>Example of class Order.</returns>
        public Order OrderFormation(List<IProduct> products);
    }
}
