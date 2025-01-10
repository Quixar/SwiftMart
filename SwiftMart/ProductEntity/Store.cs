namespace SwiftMart.ProductEntity
{
    public class Store
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }

        public Store(string name)
        {
            Name = name;
            Products = new List<Product>();
        }
    }
}
