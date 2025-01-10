using SwiftMart.Accounts;
using SwiftMart.DataBase;
using SwiftMart.Sessions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftMart.Services
{
    public class CustomerAccountService
    {
        private readonly Context context;

        public CustomerAccountService()
        {
            context = new Context();
        }

        public void CreateCustomerAccount()
        {
            var wishList = context.Wishlists.FirstOrDefault(w => w.CustomerId == CustomerSession.Instance.Id);

            var customerAccount = new CustomerAccount()
            {
                CustomerId = CustomerSession.Instance.Id,
                Wishlist = wishList
            };

            context.CustomerAccounts.Add(customerAccount);
            context.SaveChanges();
        }
    }
}
