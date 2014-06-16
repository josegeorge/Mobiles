using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mobiles.Data.Models.Mapping
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(200);

            this.Property(t => t.Description)
                .HasMaxLength(1000);

            this.Property(t => t.ImageUrl)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Products");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.ImageUrl).HasColumnName("ImageUrl");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.AddedDate).HasColumnName("AddedDate");
            this.Property(t => t.LastModifiedDate).HasColumnName("LastModifiedDate");
            this.Property(t => t.Brand_Id).HasColumnName("Brand_Id");

            // Relationships
            this.HasOptional(t => t.Brand)
                .WithMany(t => t.Products)
                .HasForeignKey(d => d.Brand_Id);

        }
    }
}
