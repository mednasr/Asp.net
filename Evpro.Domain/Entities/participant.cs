using System;
using System.Collections.Generic;

namespace Evpro.Domain.Entities
{
    public partial class participant
    {
        public participant()
        {
            this.comments = new List<comment>();
            this.payments = new List<payment>();
            this.satisfactionsurveys = new List<satisfactionsurvey>();
            this.ourevents = new List<ourevent>();
        }

        public bool vip { get; set; }
        public int idUser { get; set; }
        public Nullable<int> rewardP_id { get; set; }
        public virtual ICollection<comment> comments { get; set; }
        public virtual user user { get; set; }
        public virtual ICollection<payment> payments { get; set; }
        public virtual reward reward { get; set; }
        public virtual ICollection<satisfactionsurvey> satisfactionsurveys { get; set; }
        public virtual ICollection<ourevent> ourevents { get; set; }
    }
}
