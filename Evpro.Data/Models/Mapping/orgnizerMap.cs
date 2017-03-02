using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Evpro.Domain.Entities;

namespace Evpro.Data.Models.Mapping
{
    public class orgnizerMap : EntityTypeConfiguration<orgnizer>
    {
        public orgnizerMap()
        {
            // Primary Key
            this.HasKey(t => t.idUser);

            // Properties
            this.Property(t => t.idUser)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("orgnizer", "event");
            this.Property(t => t.rating).HasColumnName("rating");
            this.Property(t => t.idUser).HasColumnName("idUser");

            // Relationships
            this.HasRequired(t => t.user)
                .WithOptional(t => t.orgnizer);

        }
    }
}
