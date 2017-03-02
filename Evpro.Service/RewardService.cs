using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Evpro.Data.Infrastructure;
using Evpro.Domain.Entities;
using Evpro.Service.Pattern;
using Twilio;

namespace Evpro.Service
{
    public class RewardService : MyServiceGeneric<reward>, IRewardService
    {
        private static IDataBaseFactory dbfac = new DataBaseFactory();

        private static IUnitOfWork utw = new UnitOfWork(dbfac);

        public RewardService():base(utw)
        {

        }

        public void sendSMS()
        {
            //var accountSid = "ACe598fe12f038ba48e54de36ade4b539f"; // Your Account SID from www.twilio.com/console
            //var authToken = "{{b7fb832d57a76e77b4fa61b671dfe7ee}}";  // Your Auth Token from www.twilio.com/console

            //var twilio = new TwilioRestClient(accountSid, authToken);
            //var message = twilio.SendMessage(
            //    "+15025140604", // From (Replace with your Twilio number)
            //    "+21654061364", // To (Replace with your phone number)
            //                "vous avez gagné un cadeau de la part de Evpro-vent , veuillez verifier votre mail merci de votre fidélité"
            //          );


        }



    }
}
