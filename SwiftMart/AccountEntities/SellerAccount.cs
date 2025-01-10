using SwiftMart.ProductEntity;
using System.Security.Cryptography.X509Certificates;

/// <summary>
/// Represents a seller account within the SwiftMart system.
/// Inherits from the <see cref="Account"/> class and includes seller-specific details,
/// such as the store name and associated products.
/// </summary>
namespace SwiftMart.Accounts
{
    public class SellerAccount : Account
    {

        /// <summary>
        /// Gets or sets the name of the seller's store.
        /// This property is used to identify the seller's business within the system.
        /// </summary>
        public string? StoreName { get; set; }


        // Uncomment and implement when the product list feature is added.
        // /// <summary>
        // /// Gets or sets the list of products associated with the seller account.
        // /// Represents all products managed by the seller.
        // /// </summary>
        // public List<Product> Products { get; set; }

        /// <summary>
        /// Displays the personal information of the seller account.
        /// Override this method to provide seller-specific implementation for viewing account details.
        /// </summary>
        public void ViewPersonalInfo()
        {

        }

        /// <summary>
        /// Displays the dashboard for the seller account.
        /// Override this method to provide seller-specific implementation for managing the store and products.
        /// </summary>
        public void DisplayDashboard()
        {

        }
    }
}
