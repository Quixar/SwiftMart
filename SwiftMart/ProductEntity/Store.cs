
/// <summary>
/// Represents a store in the SwiftMart system. The store holds a list of products and has a name.
/// </summary>
namespace SwiftMart.ProductEntity
{
    public class Store
    {

        /// <summary>
        /// Gets or sets the name of the store.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the list of products available in the store.
        /// </summary>
        public List<Product> Products { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Store"/> class with a specified store name.
        /// </summary>
        /// <param name="name">The name of the store.</param>
        public Store(string name)
        {
            Name = name;
            Products = new List<Product>();
        }
    }
}
