using SwiftMart.WishlistEntity;
using SwiftMart.OrderEntities;
using SwiftMart.AddressEntity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

/// <summary>
/// Represents a customer in the SwiftMart system, inheriting from the base user class.
/// A customer can have a shopping cart, order history, and a wishlist.
/// </summary>
namespace SwiftMart.UserEntities
{
    [Index(nameof(Email), IsUnique = true)]
    public class Customer : User
    {
        /// <summary>
        /// Gets or sets the unique identifier for the customer.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the customer.
        /// </summary>
        public Cart? Cart { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the customer.
        /// </summary>
        public ICollection<Order> OrderHistory { get; set; } = new List<Order>();

        /// <summary>
        /// Gets or sets the unique identifier for the customer.
        /// </summary>
        public Wishlist? Wishlist { get; set; }

        //public void BuyProduct(Product product)
        //{

        //}

        //public void CancelOrder(Order order)
        //{

        //}
    }
}
