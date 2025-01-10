using SwiftMart.UserEntities;
using System.ComponentModel.DataAnnotations;

/// <summary>
/// Represents a shopping cart for a customer, which holds the products that the customer intends to purchase.
/// This class provides methods to manage the cart, such as adding, removing, and clearing products (methods are currently commented out).
/// </summary>
namespace SwiftMart.OrderEntities
{
    public class Cart
    {

        /// <summary>
        /// Gets or sets the unique identifier of the cart.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the customer ID associated with the cart.
        /// This links the cart to a specific customer in the system.
        /// </summary>
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
