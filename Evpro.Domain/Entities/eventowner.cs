using System;
using System.Collections.Generic;

namespace Evpro.Domain.Entities
{
    public partial class eventowner
    {
        public eventowner()
        {
            this.ourevents = new List<ourevent>();
        }

        public int idUser { get; set; }
        public virtual ICollection<ourevent> ourevents { get; set; }
        public virtual user user { get; set; }
    }
}
