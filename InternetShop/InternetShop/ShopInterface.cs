using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop
{
    internal class ShopInterface : IShopInterface
    {
        public void ShowProducts(in List<IProduct> products)
        {
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {products[i].Name}\tPrice: {products[i].Price}");
                Console.WriteLine($"Description: {products[i].Description}");
            }
        }

        public IBuyer Ordering(List<IProduct> orderList)
        {
        }
    }
}
