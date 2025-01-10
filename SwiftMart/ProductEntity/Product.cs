
using SwiftMart.ReviewEntity;
using System.ComponentModel.DataAnnotations;

/// <summary>
/// Represents a product in the system, including details like name, description, price, photos, and reviews.
/// This class serves as a base for specific product types such as phones, laptops, etc.
/// </summary>
namespace SwiftMart.ProductEntity
{
    public partial class Product
    {

        /// <summary>
        /// Gets or sets the unique identifier for the product.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the product.
        /// This represents the product's title or label (e.g., "iPhone 13").
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the product.
        /// This provides additional details about the product (e.g., features, specifications, etc.).
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets the price of the product.
        /// This represents the product's cost in the system (e.g., 999.99).
        /// </summary>
        public float Price { get; set; }

        /// <summary>
        /// Gets or sets the collection of reviews associated with the product.
        /// Reviews provide feedback and ratings from customers regarding the product.
        /// </summary>
        public ICollection<Review>? Reviews { get; set; } = new List<Review>();

        /// <summary>
        /// Gets or sets the list of photos associated with the product.
        /// Photos are stored as URLs or file paths pointing to product images.
        /// </summary>
        public List<string> Photos { get; set; } = new List<string>();

    }
}
