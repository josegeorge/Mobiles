using System.Data.Entity;
using Mobiles.Data.Models;
using Mobiles.Data.Models.Mapping;

namespace Mobiles.Data
{
    public partial class MobileDetailsDbContext : DbContext
    {
        static MobileDetailsDbContext()
        {
            Database.SetInitializer<MobileDetailsDbContext>(null);
        }

        public MobileDetailsDbContext()
            : base("Name=MobileDetailsDbContext")
        {
        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductSpecificaton> ProductSpecificatons { get; set; }
        public DbSet<SpecifictionHeading> SpecifictionHeadings { get; set; }
        public DbSet<SpecifictionHeadingValue> SpecifictionHeadingValues { get; set; }
        public DbSet<SpecifictionType> SpecifictionTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BrandMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new ProductSpecificatonMap());
            modelBuilder.Configurations.Add(new SpecifictionHeadingMap());
            modelBuilder.Configurations.Add(new SpecifictionHeadingValueMap());
            modelBuilder.Configurations.Add(new SpecifictionTypeMap());
        }
    }
}
