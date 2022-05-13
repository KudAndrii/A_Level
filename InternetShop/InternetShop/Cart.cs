using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop
{
    /// <summary>
    /// Shopping cart, contains List of Iproduct (ShoppingCart).
    /// </summary>
    internal class Cart
    {
        public List<IProduct> ShoppingCart { get; set; }
    }
}
