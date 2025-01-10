using SwiftMart.OrderEntities;
using SwiftMart.UserEntities;
using SwiftMart.WishlistEntity;
using System.ComponentModel.DataAnnotations;

namespace SwiftMart.Accounts
{
    public class CustomerAccount : Account
    {
        [Key]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;
        public ICollection<Order>? OrderHistory { get; set; } = new List<Order>();
        public Wishlist? Wishlist { get; set; }

        //public void ViewPersonalInfo()
        //{

        //}

        //public void DisplayDashboard()
        //{

        //}
    }
}
