using SwiftMart.Accounts;
using SwiftMart.DataBase;
using SwiftMart.Sessions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Provides services for managing customer accounts in the SwiftMart system.
/// Includes operations for creating customer accounts and associating them with a wishlist.
/// </summary>
namespace SwiftMart.Services
{
    public class CustomerAccountService
    {
        private readonly Context context;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerAccountService"/> class.
        /// </summary>
        public CustomerAccountService()
        {
            context = new Context();
        }

        /// <summary>
        /// Creates a customer account and associates it with the customer's wishlist.
        /// The customer account is saved to the database.
        /// </summary>
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
