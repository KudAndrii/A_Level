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
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name}\tPrice: {product.Price}\tDescription: {product.Description}");
            }
        }

        public void OrderInfo(Order order)
        {
            Console.WriteLine($"Order number:{new Random().Next(1, 100)}," +
                $"mr {order.Buyer.Name} {order.Buyer.Surname} is ready to sending, amount payable: {order.FinalPrice}");
        }
    }
}
