﻿using System;
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

        public void OrderInfo(List<IProduct> orderList);
    }
}
