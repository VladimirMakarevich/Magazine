using Magazine.DAL.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Magazine.DAL.Context
{
    class MagazineContext : DbContext
    {
        public MagazineContext() : base("name=MagazineDb")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Item> Merchandises { get; set; }
        public DbSet<Store> Magazines { get; set; }
    }
}
