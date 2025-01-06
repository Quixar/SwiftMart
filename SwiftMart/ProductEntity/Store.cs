using SwiftMart.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftMart.ProductEntity
{
    public class Store
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }

        public Store(string name)
        {
            Name = name;
            Products = new List<Product>();
        }
    }
}
