using System;
using System.Collections.Generic;

namespace InternetShop
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            new ShopInterface().ShopMenu(ProductRange.Instance.Products);
        }
    }
}
