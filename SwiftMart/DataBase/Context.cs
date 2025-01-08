using Microsoft.EntityFrameworkCore;
using SwiftMart.AddressEntity;
using SwiftMart.BankCard;
using SwiftMart.OrderEntities;
using SwiftMart.ReviewEntity;
using SwiftMart.UserEntities;
using SwiftMart.WishlistEntity;

namespace SwiftMart.DataBase
{
    public class Context : DbContext
    {
        public Context()
        {
           // Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"host=localhost;port=5432;database=swiftmart;username=postgres;password=root");

        }

        public DbSet<Card> Cards { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<ProductEntity.Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Wishlist> Wishlists { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Customer> Customers  { get; set; }
    }
}
