using System;
using System.Collections.Generic;

namespace Evpro.Domain.Entities
{
    public partial class payment
    {
        public int idEvent { get; set; }
        public int idParticipant { get; set; }
        public Nullable<int> paymentAmount { get; set; }
        public Nullable<System.DateTime> paymentDate { get; set; }
        public string paymentStatus { get; set; }
        public virtual ourevent ourevent { get; set; }
        public virtual participant participant { get; set; }
    }
}
