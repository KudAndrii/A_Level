using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop
{
    internal class ProductRange
    {
        public ProductRange()
        {
            Products.Add(new Product(10, "Pen", "Do not ingest"));
            Products.Add(new Product(8, "Pencil", "Cheaper than a pen"));
            Products.Add(new Product(15, "Ruler", "Precision tool"));
            Products.Add(new Product(5, "Rubber", "Cannot erase your sins"));
            Products.Add(new Product(20, "Marker", "Very thick"));
        }

        public List<IProduct> Products { get; }
    }
}
