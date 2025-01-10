using Microsoft.EntityFrameworkCore;
using SwiftMart.Accounts;
using SwiftMart.AddressEntity;
using SwiftMart.BankCard;
using SwiftMart.CategoryEntity;
using SwiftMart.OrderEntities;
using SwiftMart.ReviewEntity;
using SwiftMart.UserEntities;
using SwiftMart.WishlistEntity;
using SwiftMartCRM.CategoryEntity;
using SwiftMartCRM.ProductEntity;

namespace SwiftMart.DataBase
{
    public class Context : DbContext
    {
        public Context()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"host=localhost;port=5432;database=swiftmart;username=postgres;password=root");

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }
        public DbSet<TV> TVs { get; set; }
        public DbSet<Admin> Admins { get; set; }


        public DbSet<CustomerAccount> CustomerAccounts { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Wishlist> Wishlists { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Customer> Customers  { get; set; }
    }
}
