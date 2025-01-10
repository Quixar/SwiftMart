using SwiftMart.AddressEntity;
using SwiftMart.Status;
using SwiftMart.UserEntities;
using System.ComponentModel.DataAnnotations;

/// <summary>
/// Represents an order placed by a customer, including the products in the order, order status, delivery address, 
/// total price, and the creation date of the order.
/// </summary>
namespace SwiftMart.OrderEntities
{
    public class Order
    {

        /// <summary>
        /// Gets or sets the unique identifier for the order.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the customer ID associated with the order.
        /// This links the order to a specific customer in the system.
        /// </summary>
        public int CustomerID { get; set; }

        /// <summary>
        /// Gets or sets the customer who placed the order.
        /// The <see cref="Customer"/> object provides detailed information about the customer.
        /// </summary>
        public Customer Customer { get; set; } = null!;

        /// <summary>
        /// Gets or sets the list of products in the order.
        /// This collection contains all products that were ordered.
        /// </summary>
        public ICollection<ProductEntity.Product>? Products { get; set; } = new List<ProductEntity.Product>();

        /// <summary>
        /// Gets or sets the status of the order.
        /// The <see cref="OrderStatus"/> value indicates the current state of the order (e.g., pending, shipped, delivered).
        /// </summary>
        public OrderStatus Status { get; set; }

        /// <summary>
        /// Gets or sets the delivery address for the order.
        /// This address is where the order will be shipped to.
        /// </summary>
        public Address? DeliveryAddress { get; set; }

        /// <summary>
        /// Gets or sets the date when the order was created.
        /// </summary>
        public DateOnly CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the total price of the order.
        /// This value represents the sum of the prices of all products in the order.
        /// </summary>
        public float TotalPrice { get; set; }
    }
}
