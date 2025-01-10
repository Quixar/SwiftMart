using SwiftMart.DataBase;
using SwiftMart.Sessions;
using SwiftMart.WishlistEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Provides services for managing customer wishlists in the SwiftMart system.
/// Includes operations for creating a new wishlist for a customer.
/// </summary>
namespace SwiftMart.Services
{
    public class WishlistService
    {
        private readonly Context context;

        /// <summary>
        /// Initializes a new instance of the <see cref="WishlistService"/> class.
        /// </summary>
        public WishlistService()
        {
            context = new Context();
        }

        /// <summary>
        /// Creates a new wishlist for the currently logged-in customer.
        /// The wishlist is added to the database context and changes are saved.
        /// </summary>
        public void CreateWishlist()
        {
            var wishList = new Wishlist()
            {
                CustomerId = CustomerSession.Instance.Id,
            };

            context.Wishlists.Add(wishList);
            context.SaveChanges();
        }
    }
}
