using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Evpro.Domain.Entities;

namespace Evpro.Data.Models.Mapping
{
    public class messageMap : EntityTypeConfiguration<message>
    {
        public messageMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.description)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("message", "event");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.date).HasColumnName("date");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.id_destinataire).HasColumnName("id_destinataire");
            this.Property(t => t.statut).HasColumnName("statut");
            this.Property(t => t.orgnizer_idUser).HasColumnName("orgnizer_idUser");

            // Relationships
            this.HasOptional(t => t.orgnizer)
                .WithMany(t => t.messages)
                .HasForeignKey(d => d.orgnizer_idUser);

        }
    }
}
