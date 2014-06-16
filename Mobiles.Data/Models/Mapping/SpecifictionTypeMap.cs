using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mobiles.Data.Models.Mapping
{
    public class SpecifictionTypeMap : EntityTypeConfiguration<SpecifictionType>
    {
        public SpecifictionTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("SpecifictionTypes");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
        }
    }
}
