using System;
using System.Collections.Generic;

namespace Evpro.Domain.Entities
{
    public partial class comment
    {
        public int idEvent { get; set; }
        public int idParticipant { get; set; }
        public string message { get; set; }
        public string startComment { get; set; }
        public virtual participant participant { get; set; }
        public virtual ourevent ourevent { get; set; }
    }
}
