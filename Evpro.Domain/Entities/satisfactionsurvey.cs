using System;
using System.Collections.Generic;

namespace Evpro.Domain.Entities
{
    public partial class satisfactionsurvey
    {
        public int idSurvey { get; set; }
        public Nullable<System.DateTime> creationDate { get; set; }
        public string descreptiveText { get; set; }
        public string messageInfo { get; set; }
        public bool status { get; set; }
        public Nullable<int> idEvent_fk { get; set; }
        public Nullable<int> idParticipant { get; set; }
        public virtual ourevent ourevent { get; set; }
        public virtual participant participant { get; set; }
    }
}
