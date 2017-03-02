using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Evpro.Domain.Entities;

namespace Evpro.Data.Models.Mapping
{
    public class userMap : EntityTypeConfiguration<user>
    {
        public userMap()
        {
            // Primary Key
            this.HasKey(t => t.idUser);

            // Properties
            this.Property(t => t.cityAdress)
                .HasMaxLength(255);

            this.Property(t => t.company)
                .HasMaxLength(255);

            this.Property(t => t.countryAdress)
                .HasMaxLength(255);

            this.Property(t => t.firstName)
                .HasMaxLength(255);

            this.Property(t => t.gender)
                .HasMaxLength(255);

            this.Property(t => t.lastName)
                .HasMaxLength(255);

            this.Property(t => t.mail)
                .HasMaxLength(255);

            this.Property(t => t.nickName)
                .HasMaxLength(255);

            this.Property(t => t.password)
                .HasMaxLength(255);

            this.Property(t => t.phoneNumber)
                .HasMaxLength(255);

            this.Property(t => t.postalCode)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("user", "event");
            this.Property(t => t.idUser).HasColumnName("idUser");
            this.Property(t => t.birthDate).HasColumnName("birthDate");
            this.Property(t => t.cityAdress).HasColumnName("cityAdress");
            this.Property(t => t.company).HasColumnName("company");
            this.Property(t => t.countryAdress).HasColumnName("countryAdress");
            this.Property(t => t.firstName).HasColumnName("firstName");
            this.Property(t => t.gender).HasColumnName("gender");
            this.Property(t => t.laltitude).HasColumnName("laltitude");
            this.Property(t => t.lastName).HasColumnName("lastName");
            this.Property(t => t.longitude).HasColumnName("longitude");
            this.Property(t => t.mail).HasColumnName("mail");
            this.Property(t => t.nickName).HasColumnName("nickName");
            this.Property(t => t.password).HasColumnName("password");
            this.Property(t => t.phoneNumber).HasColumnName("phoneNumber");
            this.Property(t => t.postalCode).HasColumnName("postalCode");
        }
    }
}
