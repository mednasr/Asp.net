using System;
using System.Collections.Generic;
using System.Linq;
using Evpro.Data.Infrastructure;
using Evpro.Domain.Entities;
using Evpro.Service.Pattern;
using Twilio;

namespace Evpro.Service
      {
      public class SatisfactionSurveyService : MyServiceGeneric<satisfactionsurvey>, ISatisfactionSurveyService
            {
            private static IDataBaseFactory dbfac = new DataBaseFactory();

            private static IUnitOfWork utw = new UnitOfWork(dbfac);
            IEvenementService evsr = new EvenementService();
            IParticipantService ptsr = new ParticipantService();

            public SatisfactionSurveyService() : base(utw)
                  {
                  }

            public string eventName(int? id)
                  {
                  string rs = (from vnd in evsr.GetMany()
                               where vnd.idEvent == id
                               select vnd.name).First().ToString();
                   
                  return rs;
                  
                  


                  }

            public int getnbrUserSatisfied()
                  {
                  int rs = (from satis in this.GetMany().ToList()
                            join user in ptsr.GetMany().ToList() on satis.idParticipant equals user.idUser
                            where user.user.company == "esprit"
                            select satis.idParticipant).Count();

                        int tot = GetMany().ToList().Count();

                        int rsfn = (rs*100)/tot;
                        return rsfn  ;
                  }


                  public List<string> getAlleventsNames()
                  {
                        var listeventnames = from satis in this.GetMany().ToList()
                              join ev in evsr.GetMany().ToList() on satis.idEvent_fk equals ev.idEvent
                              where satis.status == true
                              select ev.name;
                        List<string> evnames = listeventnames.ToList();

                        return evnames;




                  }

                  public void sendSMS( )
                  { 
                var accountSid = "ACe598fe12f038ba48e54de36ade4b539f"; // Your Account SID from www.twilio.com/console
            var authToken = "{{b7fb832d57a76e77b4fa61b671dfe7ee}}";  // Your Auth Token from www.twilio.com/console

            var twilio = new TwilioRestClient(accountSid, authToken);
            var message = twilio.SendMessage(
                "+1 502-514-0604 ", // From (Replace with your Twilio number)
                "+21694400610", // To (Replace with your phone number)
                            "vous avez gagné un cadeau de la part de Evpro-vent , veuillez verifier votre mail merci de votre fidélité"
                      );

               
                  }
            }
      }