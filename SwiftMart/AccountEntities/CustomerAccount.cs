using SwiftMart.OrderEntities;
using SwiftMart.UserEntities;
using SwiftMart.WishlistEntity;
using System.ComponentModel.DataAnnotations;

/// <summary>
/// Represents a customer account within the SwiftMart system.
/// Inherits from the <see cref="Account"/> class and includes customer-specific details,
/// such as associated customer data, order history, and wishlist.
/// </summary>
namespace SwiftMart.Accounts
{
    public class CustomerAccount : Account
    {

        /// <summary>
        /// Gets or sets the unique identifier for the customer account.
        /// Serves as the primary key in the database.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the identifier for the associated customer entity.
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the customer details associated with this account.
        /// This navigation property links the account to the corresponding customer entity.
        /// </summary>
        public Customer Customer { get; set; } = null!;

        /// <summary>
        /// Gets or sets the order history for the customer account.
        /// This collection contains all orders made by the customer.
        /// </summary>
        public ICollection<Order>? OrderHistory { get; set; } = new List<Order>();

        /// <summary>
        /// Gets or sets the wishlist associated with the customer account.
        /// Contains items the customer has saved for future purchases.
        /// </summary>
        public Wishlist? Wishlist { get; set; }

        // Uncomment and implement if customer-specific behavior for viewing personal information is required.
        //public override void ViewPersonalInfo()
        //{
        //    // Implementation for viewing personal info specific to CustomerAccount.
        //}

        // Uncomment and implement if customer-specific behavior for displaying a dashboard is required.
        //public override void DisplayDashboard()
        //{
        //    // Implementation for displaying dashboard specific to CustomerAccount.
        //}
    }
}
