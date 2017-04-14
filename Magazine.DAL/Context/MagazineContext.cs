using Magazine.DAL.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Magazine.DAL.Context
{
    public class MagazineContext : DbContext
    {
        public MagazineContext() : base("name=MagazineDb")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Store> Stores { get; set; }
    }
}
