
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

/// <summary>
/// Represents a user in the SwiftMart platform. The user can be an admin, customer, or seller.
/// </summary>
namespace SwiftMart.UserEntities
{
   
    public partial class User
    {

        /// <summary>
        /// Gets or sets the first name of the user.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the last name of the user.
        /// </summary>
        public string? Lastname { get; set; }

        /// <summary>
        /// Gets or sets the email address of the user. This is unique across the platform.
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// Gets or sets the password of the user, which is hashed for security.
        /// </summary>
        public string? Password { get; set; }

        /// <summary>
        /// Gets or sets the role of the user. Roles can include admin, customer, or seller.
        /// </summary>
        public string? Role { get; set; }
    }
}
