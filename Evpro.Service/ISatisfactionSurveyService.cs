using System.Collections.Generic;
using Evpro.Domain.Entities;
using Evpro.Service.Pattern;

namespace Evpro.Service
{
      public interface ISatisfactionSurveyService: IMyServiceGeneric<satisfactionsurvey>
      {
            string eventName(int? id);

            int getnbrUserSatisfied();

            List<string> getAlleventsNames();

            void sendSMS( );


      }
}