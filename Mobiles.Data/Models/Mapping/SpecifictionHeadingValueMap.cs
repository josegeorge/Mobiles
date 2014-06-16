using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mobiles.Data.Models.Mapping
{
    public class SpecifictionHeadingValueMap : EntityTypeConfiguration<SpecifictionHeadingValue>
    {
        public SpecifictionHeadingValueMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("SpecifictionHeadingValues");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.Heading_Id).HasColumnName("Heading_Id");

            // Relationships
            this.HasOptional(t => t.SpecifictionHeading)
                .WithMany(t => t.SpecifictionHeadingValues)
                .HasForeignKey(d => d.Heading_Id);

        }
    }
}
