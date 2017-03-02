using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Evpro.Domain.Entities;

namespace Evpro.Data.Models.Mapping
{
    public class participantMap : EntityTypeConfiguration<participant>
    {
        public participantMap()
        {
            // Primary Key
            this.HasKey(t => t.idUser);

            // Properties
            this.Property(t => t.idUser)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("participant", "event");
            this.Property(t => t.vip).HasColumnName("vip");
            this.Property(t => t.idUser).HasColumnName("idUser");
            this.Property(t => t.rewardP_id).HasColumnName("rewardP_id");

            // Relationships
            this.HasRequired(t => t.user)
                .WithOptional(t => t.participant);
            this.HasOptional(t => t.reward)
                .WithMany(t => t.participants)
                .HasForeignKey(d => d.rewardP_id);

        }
    }
}
