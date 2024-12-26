using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftMart.DataBase
{
    public class Context : DbContext
    {
        public Context()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"host=localhost;port=5432;database=SpotifyCSharp;username=postgres;password=root");
        }

        //public DbSet<Performer> Performers { get; set; }

        //public DbSet<Song> Songs { get; set; }

        //public DbSet<Radio> Radios { get; set; }

        //public DbSet<MusicCollection> MusicCollections { get; set; }
    }
}
