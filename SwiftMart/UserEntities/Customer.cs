using System;
using SwiftMart.WishlistEntity;
using SwiftMart.OrderEntities;
using SwiftMart.ProductEntities;

namespace SwiftMart.UserEntities
{
    internal class Customer : User
    {
        public Cart Cart { get; set; }
        public List<Order> Orders { get; set; }
        public Wishlist Wishlist { get; set; }

        public void BuyProduct(Product product)
        {
            
        }

        public void CancelOrder(Order order)
        {
           
        }
    }
}