using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mobiles.Data.Models.Mapping
{
    public class ProductSpecificatonMap : EntityTypeConfiguration<ProductSpecificaton>
    {
        public ProductSpecificatonMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("ProductSpecificatons");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.HeadingValue_Id).HasColumnName("HeadingValue_Id");
            this.Property(t => t.Product_Id).HasColumnName("Product_Id");

            // Relationships
            this.HasOptional(t => t.Product)
                .WithMany(t => t.ProductSpecificatons)
                .HasForeignKey(d => d.Product_Id);
            this.HasOptional(t => t.SpecifictionHeadingValue)
                .WithMany(t => t.ProductSpecificatons)
                .HasForeignKey(d => d.HeadingValue_Id);

        }
    }
}
