using System;
using System.Collections.Generic;

namespace Evpro.Domain.Entities
{
    public partial class orgnizer
    {
        public orgnizer()
        {
            this.messages = new List<message>();
            this.tasks = new List<task>();
            this.ourevents = new List<ourevent>();
        }

        public float rating { get; set; }
        public int idUser { get; set; }
        public virtual ICollection<message> messages { get; set; }
        public virtual user user { get; set; }
        public virtual ICollection<task> tasks { get; set; }
        public virtual ICollection<ourevent> ourevents { get; set; }
    }
}
