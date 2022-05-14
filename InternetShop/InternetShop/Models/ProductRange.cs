using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop
{
    /// <summary>
    /// Singleton class with range of products accessible to buying.
    /// </summary>
    internal sealed class ProductRange
    {
        private static readonly Lazy<ProductRange> Lazy = new Lazy<ProductRange>(() => new ProductRange());
        static ProductRange()
        {
        }

        private ProductRange()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product(10, "Pen", "Do not ingest"));
            products.Add(new Product(8, "Pencil", "Cheaper than a pen"));
            products.Add(new Product(15, "Ruler", "Precision tool"));
            products.Add(new Product(5, "Rubber", "Cannot erase your sins"));
            products.Add(new Product(20, "Marker", "Very thick"));
            Products = products;
        }

        public static ProductRange Instance
        {
            get
            {
                return Lazy.Value;
            }
        }

        public List<Product> Products { get; }
    }
}
