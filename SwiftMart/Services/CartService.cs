using SwiftMart.DataBase;
using SwiftMart.OrderEntities;
using SwiftMart.Sessions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Provides services for managing shopping carts in the SwiftMart system.
/// Includes operations for saving a cart for a user.
/// </summary>
namespace SwiftMart.Services
{
    public class CartService
    {
        private readonly Context context;

        /// <summary>
        /// Initializes a new instance of the <see cref="CartService"/> class.
        /// </summary>
        public CartService() 
        {
            context = new Context();
        }

        /// <summary>
        /// Saves a new shopping cart for the currently logged-in customer.
        /// The cart is associated with the customer using the customer ID stored in the session.
        /// </summary>
        public void SaveCart()
        {
            var cart = new Cart()
            {
                CustomerId = CustomerSession.Instance.Id,
            };

            context.Carts.Add(cart);
            context.SaveChanges();
        }
    }
}
