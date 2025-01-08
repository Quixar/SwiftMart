
using SwiftMart.ReviewEntity;

namespace SwiftMart.ProductEntity
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        //public Category Category { get; set; } -- TO DO
        public Review Review { get; set; }

    }
}
