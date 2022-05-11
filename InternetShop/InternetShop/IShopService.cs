using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop
{
    internal interface IShopService
    {
        public List<IProduct> ShoppingCart { get; }

        /// <summary>
        /// Method adding products to incoming list of products.
        /// </summary>
        /// <param name="products">Incoming list of products.</param>
        public void AddProduct(List<IProduct> products);

        /// <summary>
        /// Method generating order.
        /// </summary>
        /// <param name="products">List of products, which whould be buyed.</param>
        /// <returns>Example of class Order.</returns>
        public Order OrderFormation(List<IProduct> products);
    }
}
