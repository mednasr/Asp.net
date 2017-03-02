using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Evpro.Domain.Entities;

namespace Evpro.Data.Models.Mapping
{
    public class oureventMap : EntityTypeConfiguration<ourevent>
    {
        public oureventMap()
        {
            // Primary Key
            this.HasKey(t => t.idEvent);

            // Properties
            this.Property(t => t.category)
                .HasMaxLength(255);

            this.Property(t => t.cityAdress)
                .HasMaxLength(255);

            this.Property(t => t.countryAdress)
                .HasMaxLength(255);

            this.Property(t => t.description)
                .HasMaxLength(255);

            this.Property(t => t.eventType)
                .HasMaxLength(255);

            this.Property(t => t.facebookEventLink)
                .HasMaxLength(255);

            this.Property(t => t.name)
                .HasMaxLength(255);

            this.Property(t => t.slogan)
                .HasMaxLength(255);

            this.Property(t => t.tag)
                .HasMaxLength(255);

            this.Property(t => t.twitterEventLink)
                .HasMaxLength(255);

            this.Property(t => t.video)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("ourevent", "event");
            this.Property(t => t.idEvent).HasColumnName("idEvent");
            this.Property(t => t.category).HasColumnName("category");
            this.Property(t => t.cityAdress).HasColumnName("cityAdress");
            this.Property(t => t.countryAdress).HasColumnName("countryAdress");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.eventFinishingDate).HasColumnName("eventFinishingDate");
            this.Property(t => t.eventStartingDate).HasColumnName("eventStartingDate");
            this.Property(t => t.eventType).HasColumnName("eventType");
            this.Property(t => t.facebookEventLink).HasColumnName("facebookEventLink");
            this.Property(t => t.image).HasColumnName("image");
            this.Property(t => t.laltitude).HasColumnName("laltitude");
            this.Property(t => t.longitude).HasColumnName("longitude");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.price).HasColumnName("price");
            this.Property(t => t.slogan).HasColumnName("slogan");
            this.Property(t => t.tag).HasColumnName("tag");
            this.Property(t => t.twitterEventLink).HasColumnName("twitterEventLink");
            this.Property(t => t.video).HasColumnName("video");
            this.Property(t => t.owner_idUser).HasColumnName("owner_idUser");
            this.Property(t => t.reward_id).HasColumnName("reward_id");

            // Relationships
            this.HasMany(t => t.features)
                .WithMany(t => t.ourevents)
                .Map(m =>
                    {
                        m.ToTable("ourevent_feature", "event");
                        m.MapLeftKey("events_idEvent");
                        m.MapRightKey("features_id");
                    });

            this.HasMany(t => t.orgnizers)
                .WithMany(t => t.ourevents)
                .Map(m =>
                    {
                        m.ToTable("ourevent_orgnizer", "event");
                        m.MapLeftKey("events_idEvent");
                        m.MapRightKey("orgnizerEvents_idUser");
                    });

            this.HasMany(t => t.participants)
                .WithMany(t => t.ourevents)
                .Map(m =>
                    {
                        m.ToTable("ourevent_participant", "event");
                        m.MapLeftKey("events_idEvent");
                        m.MapRightKey("eventParticipants_idUser");
                    });

            this.HasOptional(t => t.eventowner)
                .WithMany(t => t.ourevents)
                .HasForeignKey(d => d.owner_idUser);
            this.HasOptional(t => t.reward)
                .WithMany(t => t.ourevents)
                .HasForeignKey(d => d.reward_id);

        }
    }
}
