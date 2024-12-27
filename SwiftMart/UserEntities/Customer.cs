using SwiftMart.Products;
using SwiftMart.WishlistEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using SwiftMart.OrderEntities;

namespace SwiftMart.UserEntities
{
    public class Customer
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
