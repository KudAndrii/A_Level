using System;
using System.Collections.Generic;

namespace InternetShop
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ShopInterface shopInterface = new ();
            shopInterface.ShopMenu(ProductRange.Instance.Products);
        }
    }
}
