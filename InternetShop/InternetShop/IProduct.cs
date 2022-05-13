using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop
{
    /// <summary>
    /// Contains price, name and description.
    /// </summary>
    internal interface IProduct
    {
        public int Price { get; }
        public string Name { get; }
        public string Description { get; }
    }
}
