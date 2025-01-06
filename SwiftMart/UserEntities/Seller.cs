using SwiftMart.ProductEntity;
using SwiftMart.Products;
using SwiftMart.StatisticEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftMart.UserEntities
{
    public class Seller
    {
        public Store Store { get; set; }
        public List<Product> Products { get; set; }
        public SalesStatistics Statistics { get; set; }
        public void ManageStore()
        {

        }
    }
}
