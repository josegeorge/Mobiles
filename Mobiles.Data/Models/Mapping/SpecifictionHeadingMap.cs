using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mobiles.Data.Models.Mapping
{
    public class SpecifictionHeadingMap : EntityTypeConfiguration<SpecifictionHeading>
    {
        public SpecifictionHeadingMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("SpecifictionHeadings");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Type_Id).HasColumnName("Type_Id");

            // Relationships
            this.HasOptional(t => t.SpecifictionType)
                .WithMany(t => t.SpecifictionHeadings)
                .HasForeignKey(d => d.Type_Id);

        }
    }
}
