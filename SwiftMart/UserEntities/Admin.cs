using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Represents an administrator user in the SwiftMart system, inheriting from the base user class.
/// </summary>
namespace SwiftMart.UserEntities
{
    public class Admin : User
    {


        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Moderates a product based on its unique identifier.
        /// This method allows the administrator to manage the product details.
        /// </summary>
        /// <param name="productId">The unique identifier of the product to be moderated.</param>

        public void ModerateProduct(int productId)
        {

        }

        /// <summary>
        /// Manages users within the system, including actions like banning, approving, or modifying user data.
        /// </summary>

        public void ManageUsers()
        {

        }
    }
}
