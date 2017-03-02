using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Evpro.Domain.Entities;

namespace Evpro.Data.Models.Mapping
{
    public class commentMap : EntityTypeConfiguration<comment>
    {
        public commentMap()
        {
            // Primary Key
            this.HasKey(t => new { t.idEvent, t.idParticipant });

            // Properties
            this.Property(t => t.idEvent)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.idParticipant)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.message)
                .HasMaxLength(255);

            this.Property(t => t.startComment)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("comment", "event");
            this.Property(t => t.idEvent).HasColumnName("idEvent");
            this.Property(t => t.idParticipant).HasColumnName("idParticipant");
            this.Property(t => t.message).HasColumnName("message");
            this.Property(t => t.startComment).HasColumnName("startComment");

            // Relationships
            this.HasRequired(t => t.participant)
                .WithMany(t => t.comments)
                .HasForeignKey(d => d.idParticipant);
            this.HasRequired(t => t.ourevent)
                .WithMany(t => t.comments)
                .HasForeignKey(d => d.idEvent);

        }
    }
}
