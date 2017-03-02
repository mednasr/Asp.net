using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Evpro.Data.Models.Mapping;
using Evpro.Domain.Entities;

namespace Evpro.Data.Models
{
    public partial class eventContext : DbContext
    {
        static eventContext()
        {
            Database.SetInitializer<eventContext>(null);
        }

        public eventContext()
            : base("Name=eventContext")
        {
        }

        public DbSet<comment> comments { get; set; }
        public DbSet<eventowner> eventowners { get; set; }
        public DbSet<feature> features { get; set; }
        public DbSet<message> messages { get; set; }
        public DbSet<orgnizer> orgnizers { get; set; }
        public DbSet<ourevent> ourevents { get; set; }
        public DbSet<participant> participants { get; set; }
        public DbSet<payment> payments { get; set; }
        public DbSet<reward> rewards { get; set; }
        public DbSet<satisfactionsurvey> satisfactionsurveys { get; set; }
        public DbSet<task> tasks { get; set; }
        public DbSet<user> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new commentMap());
            modelBuilder.Configurations.Add(new eventownerMap());
            modelBuilder.Configurations.Add(new featureMap());
            modelBuilder.Configurations.Add(new messageMap());
            modelBuilder.Configurations.Add(new orgnizerMap());
            modelBuilder.Configurations.Add(new oureventMap());
            modelBuilder.Configurations.Add(new participantMap());
            modelBuilder.Configurations.Add(new paymentMap());
            modelBuilder.Configurations.Add(new rewardMap());
            modelBuilder.Configurations.Add(new satisfactionsurveyMap());
            modelBuilder.Configurations.Add(new taskMap());
            modelBuilder.Configurations.Add(new userMap());
        }
    }
}
