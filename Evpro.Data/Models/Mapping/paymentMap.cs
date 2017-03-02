using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Evpro.Domain.Entities;

namespace Evpro.Data.Models.Mapping
{
    public class paymentMap : EntityTypeConfiguration<payment>
    {
        public paymentMap()
        {
            // Primary Key
            this.HasKey(t => new { t.idEvent, t.idParticipant });

            // Properties
            this.Property(t => t.idEvent)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.idParticipant)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.paymentStatus)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("payment", "event");
            this.Property(t => t.idEvent).HasColumnName("idEvent");
            this.Property(t => t.idParticipant).HasColumnName("idParticipant");
            this.Property(t => t.paymentAmount).HasColumnName("paymentAmount");
            this.Property(t => t.paymentDate).HasColumnName("paymentDate");
            this.Property(t => t.paymentStatus).HasColumnName("paymentStatus");

            // Relationships
            this.HasRequired(t => t.ourevent)
                .WithMany(t => t.payments)
                .HasForeignKey(d => d.idEvent);
            this.HasRequired(t => t.participant)
                .WithMany(t => t.payments)
                .HasForeignKey(d => d.idParticipant);

        }
    }
}
