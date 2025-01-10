
using SwiftMart.ReviewEntity;
using System.ComponentModel.DataAnnotations;

namespace SwiftMart.ProductEntity
{
    public partial class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public float Price { get; set; }
        public ICollection<Review>? Reviews { get; set; } = new List<Review>();
        public List<string> Photos { get; set; } = new List<string>();

    }
}
