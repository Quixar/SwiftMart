using SwiftMart.UserEntities;
using System.ComponentModel.DataAnnotations;

namespace SwiftMart.OrderEntities
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        

        //public void AddToCart(Product product)
        //{

        //}
        //public void RemoveFromCart(Product product)
        //{

        //}
        //public void ClearCart(Product product)
        //{

        //}
    }
}
