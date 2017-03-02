using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Evpro.Domain.Entities;

namespace Evpro.Data.Models.Mapping
{
    public class satisfactionsurveyMap : EntityTypeConfiguration<satisfactionsurvey>
    {
        public satisfactionsurveyMap()
        {
            // Primary Key
            this.HasKey(t => t.idSurvey);

            // Properties
            this.Property(t => t.descreptiveText)
                .HasMaxLength(255);

            this.Property(t => t.messageInfo)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("satisfactionsurvey", "event");
            this.Property(t => t.idSurvey).HasColumnName("idSurvey");
            this.Property(t => t.creationDate).HasColumnName("creationDate");
            this.Property(t => t.descreptiveText).HasColumnName("descreptiveText");
            this.Property(t => t.messageInfo).HasColumnName("messageInfo");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.idEvent_fk).HasColumnName("idEvent_fk");
            this.Property(t => t.idParticipant).HasColumnName("idParticipant");

            // Relationships
            this.HasOptional(t => t.ourevent)
                .WithMany(t => t.satisfactionsurveys)
                .HasForeignKey(d => d.idEvent_fk);
            this.HasOptional(t => t.participant)
                .WithMany(t => t.satisfactionsurveys)
                .HasForeignKey(d => d.idParticipant);

        }
    }
}
