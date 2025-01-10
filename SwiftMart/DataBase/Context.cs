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

/// <summary>
/// Represents the database context for the SwiftMart system.
/// Configures the connection to the PostgreSQL database and defines the DbSet properties for each entity model.
/// </summary>
namespace SwiftMart.DataBase
{
    public class Context : DbContext
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Context"/> class.
        /// Ensures that the database is created and deleted if necessary.
        /// </summary>
        public Context()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        /// <summary>
        /// Configures the database connection and options.
        /// In this case, it connects to a PostgreSQL database.
        /// </summary>
        /// <param name="optionsBuilder">The options builder for configuring the database context.</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"host=localhost;port=5432;database=swiftmart;username=postgres;password=root");

        }

        /// <summary>
        /// Gets or sets the DbSet for <see cref="Category"/> entities.
        /// Represents a collection of all categories in the database.
        /// </summary>
        public DbSet<Category> Categories { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for <see cref="Subcategory"/> entities.
        /// Represents a collection of all subcategories in the database.
        /// </summary>
        public DbSet<Subcategory> Subcategories { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for <see cref="TV"/> entities.
        /// Represents a collection of all TV products in the database.
        /// </summary>
        public DbSet<TV> TVs { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for <see cref="Admin"/> entities.
        /// Represents a collection of all admin accounts in the database.
        /// </summary>
        public DbSet<Admin> Admins { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for <see cref="CustomerAccount"/> entities.
        /// Represents a collection of all customer accounts in the database.
        /// </summary>
        public DbSet<CustomerAccount> CustomerAccounts { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for <see cref="Card"/> entities.
        /// Represents a collection of all bank cards in the database.
        /// </summary>
        public DbSet<Card> Cards { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for <see cref="Review"/> entities.
        /// Represents a collection of all reviews in the database.
        /// </summary>
        public DbSet<Review> Reviews { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for <see cref="Cart"/> entities.
        /// Represents a collection of all carts in the database.
        /// </summary>
        public DbSet<Cart> Carts { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for <see cref="Order"/> entities.
        /// Represents a collection of all orders in the database.
        /// </summary>
        public DbSet<Order> Orders { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for <see cref="Wishlist"/> entities.
        /// Represents a collection of all wishlists in the database.
        /// </summary>
        public DbSet<Wishlist> Wishlists { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for <see cref="Address"/> entities.
        /// Represents a collection of all addresses in the database.
        /// </summary>
        public DbSet<Address> Addresses { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for <see cref="Customer"/> entities.
        /// Represents a collection of all customers in the database.
        /// </summary>
        public DbSet<Customer> Customers  { get; set; }
    }
}
