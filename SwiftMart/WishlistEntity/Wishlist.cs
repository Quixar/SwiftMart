using SwiftMart.UserEntities;
using System.ComponentModel.DataAnnotations;

/// <summary>
/// Represents a wishlist for a customer, containing the products they wish to purchase.
/// </summary>
namespace SwiftMart.WishlistEntity
{
    public class Wishlist
    {

        /// <summary>
        /// Gets or sets the unique identifier for the wishlist.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the customer who owns the wishlist.
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the customer associated with the wishlist.
        /// </summary>
        public Customer Customer { get; set; } = null!;

        /// <summary>
        /// Gets or sets the collection of products in the wishlist.
        /// </summary>
        public ICollection<ProductEntity.Product>? Products { get; set; } = new List<ProductEntity.Product>();
    }
}
