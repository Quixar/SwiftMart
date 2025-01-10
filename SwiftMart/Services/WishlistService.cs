using SwiftMart.DataBase;
using SwiftMart.Sessions;
using SwiftMart.WishlistEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftMart.Services
{
    public class WishlistService
    {
        private readonly Context context;

        public WishlistService()
        {
            context = new Context();
        }


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
