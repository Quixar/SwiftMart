using Microsoft.EntityFrameworkCore;
using SwiftMart.UserEntities;

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

        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers  { get; set; }
        //public DbSet<Seller> Sellers { get; set; }
        //public DbSet<Admin> Admins { get; set; }
        //public DbSet<Customer> Customers { get; set; }
    }
}
