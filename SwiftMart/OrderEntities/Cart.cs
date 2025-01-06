namespace SwiftMart.OrderEntities
{
    public class Cart
    {
        public int Id { get; set; }
        public List<int> ProductID { get; set; }
        public int UserId { get; set; }

        public void AddToCart(Product product)
        {

        }
        public void RemoveFromCart(Product product)
        {

        }
        public void ClearCart(Product product)
        {

        }
    }
}
