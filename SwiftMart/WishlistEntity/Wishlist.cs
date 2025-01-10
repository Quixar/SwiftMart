using SwiftMart.UserEntities;
using System.ComponentModel.DataAnnotations;

namespace SwiftMart.WishlistEntity
{
    public class Wishlist
    {
        [Key]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;
        public ICollection<ProductEntity.Product>? Products { get; set; } = new List<ProductEntity.Product>();
    }
}
