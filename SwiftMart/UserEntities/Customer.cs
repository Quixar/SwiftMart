using SwiftMart.WishlistEntity;
using SwiftMart.OrderEntities;
using SwiftMart.AddressEntity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace SwiftMart.UserEntities
{
    [Index(nameof(Email), IsUnique = true)]
    public class Customer : User
    {
        [Key]
        public int Id { get; set; }
        public Cart? Cart { get; set; }
        public List<Order>? Orders { get; set; }
        public Wishlist? Wishlist { get; set; }
        public Address? Address { get; set; }

        //public void BuyProduct(Product product)
        //{

        //}

        //public void CancelOrder(Order order)
        //{

        //}
    }
}
