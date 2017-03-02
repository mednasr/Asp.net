using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Evpro.Domain.Entities;

namespace Evpro.Data.Models.Mapping
{
    public class featureMap : EntityTypeConfiguration<feature>
    {
        public featureMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.feature1)
                .HasMaxLength(255);

            this.Property(t => t.logo)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("feature", "event");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.feature1).HasColumnName("feature");
            this.Property(t => t.logo).HasColumnName("logo");
        }
    }
}
