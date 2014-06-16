using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mobiles.Data.Models.Mapping
{
    public class BrandMap : EntityTypeConfiguration<Brand>
    {
        public BrandMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.BrandName)
                .HasMaxLength(1000);

            this.Property(t => t.ImageUrl)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("Brands");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.BrandName).HasColumnName("BrandName");
            this.Property(t => t.ImageUrl).HasColumnName("ImageUrl");
            this.Property(t => t.NumberOfProducts).HasColumnName("NumberOfProducts");
            this.Property(t => t.HasToBeMonitered).HasColumnName("HasToBeMonitered");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.AddedDate).HasColumnName("AddedDate");
            this.Property(t => t.LastModifiedDate).HasColumnName("LastModifiedDate");
        }
    }
}
