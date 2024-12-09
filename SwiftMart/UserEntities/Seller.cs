using System;
using SwiftMart.ProductEntities;
using SwiftMart.WishlistEntity;
using SwiftMart.SalesStatistic;

namespace SwiftMart.UserEntities
{
    internal class Seller : User
    {
        public Store Store { get; set; }
        public List<Product> Products { get; set; }
        public SalesStatistics Statistics { get; set; }
        public void ManageStore()
        {
            
        }
    }
}