using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Represents a generic account within the SwiftMart system.
/// Provides basic properties and methods for user account management.
/// </summary>
namespace SwiftMart.Accounts
{
    public abstract class Account
    {
        /// <summary>
        /// Gets or sets the username associated with the account.
        /// </summary>
        public string? Username { get; set; }

        /// <summary>
        /// Gets or sets the email address associated with the account.
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// Gets or sets the URL of the account's profile photo.
        /// </summary>
        public string? AccountPhotoUrl { get; set; }

        /// <summary>
        /// Displays the personal information of the account holder.
        /// This method should be implemented to provide the relevant user details.
        /// </summary>
        public void ViewPersonalInfo()
        {
            // Implementation logic for viewing personal information.
        }

        /// <summary>
        /// Updates the personal information of the account holder.
        /// This method should be implemented to modify user details such as username, email, or profile photo.
        /// </summary>
        public void UpdatePersonalInfo()
        {
            // Implementation logic for updating personal information.
        }

        /// <summary>
        /// Displays the account dashboard, showing key information and actions for the user.
        /// This method should be implemented to provide the dashboard content.
        /// </summary>
        public void DisplayDashboard()
        {
            // Implementation logic for displaying the dashboard.
        }
    }
}
