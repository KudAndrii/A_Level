using System;

namespace InternetShop
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ShopInterface shopInterface = new ShopInterface();
            shopInterface.ShowProducts(ProductRange.Products);
        }
    }
}
