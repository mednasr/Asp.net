using System;
using System.Collections.Generic;

namespace Evpro.Domain.Entities
{
    public partial class reward
    {
        public reward()
        {
            this.ourevents = new List<ourevent>();
            this.participants = new List<participant>();
        }

        public int id { get; set; }
        public string description { get; set; }
        public virtual ICollection<ourevent> ourevents { get; set; }
        public virtual ICollection<participant> participants { get; set; }
    }
}
