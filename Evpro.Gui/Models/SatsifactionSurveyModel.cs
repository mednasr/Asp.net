using System;
using System.Collections.Generic;
using System.Linq;

using Evpro.Domain.Entities;

namespace Evpro.Gui.Models
      {
      public class SatsifactionSurveyModel
            {
            public string eventName { get; set; }
            public int idSurvey { get; set; }
            public Nullable<System.DateTime> creationDate { get; set; }
            public string descreptiveText { get; set; }
            public string messageInfo { get; set; }
            public bool status { get; set; }
            public List<ourevent> satsSurveys { get; set; }
            public Nullable<int> idEvent_fk { get; set; }
            public int NbrParticipantSatisfied { get; set; }
            public Nullable<int> idParticipant { get; set; }
            public virtual ourevent ourevent { get; set; }
            public virtual participant participant { get; set; }

            }
      }