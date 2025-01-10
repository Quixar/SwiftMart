using SwiftMart.DataBase;
using SwiftMart.OrderEntities;
using SwiftMart.Sessions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftMart.Services
{
    public class CartService
    {
        private readonly Context context;

        public CartService() 
        {
            context = new Context();
        }

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
