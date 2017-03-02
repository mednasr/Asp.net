using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Evpro.Domain.Entities;

namespace Evpro.Data.Models.Mapping
{
    public class taskMap : EntityTypeConfiguration<task>
    {
        public taskMap()
        {
            // Primary Key
            this.HasKey(t => new { t.deadLineTask, t.description, t.id, t.idEvent, t.idOrgnizer, t.startTask, t.status });

            // Properties
            this.Property(t => t.description)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.idEvent)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.idOrgnizer)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.status)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("task", "event");
            this.Property(t => t.deadLineTask).HasColumnName("deadLineTask");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.idEvent).HasColumnName("idEvent");
            this.Property(t => t.idOrgnizer).HasColumnName("idOrgnizer");
            this.Property(t => t.startTask).HasColumnName("startTask");
            this.Property(t => t.status).HasColumnName("status");

            // Relationships
            this.HasRequired(t => t.orgnizer)
                .WithMany(t => t.tasks)
                .HasForeignKey(d => d.idOrgnizer);
            this.HasRequired(t => t.ourevent)
                .WithMany(t => t.tasks)
                .HasForeignKey(d => d.idEvent);

        }
    }
}
