using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Evpro.Data.Infrastructure;
using Evpro.Domain;
using Evpro.Domain.Entities;
using Evpro.Service.Pattern;


namespace Evpro.Service
{
    public class ParticipantService : MyServiceGeneric<participant>, IParticipantService
    {
        private static IDataBaseFactory dbfac = new DataBaseFactory();

        private static IUnitOfWork utw = new UnitOfWork(dbfac);

        public ParticipantService():base(utw)
        {

        }
        public void addParticipant(user p)
        {
            utw.getRepository<user>().Add(p);
            utw.commit();
        }

        public List<participant> GetPayments(ourevent events)
        {

            var query =
                from payments in utw.getRepository<payment>().GetMany(p => p.idEvent == events.idEvent)
                select payments.idParticipant;

            List<participant> part = new List<participant>();
            foreach (var p in query)
            {
                part.Add(utw.getRepository<participant>().GetById(p));
            }
            return part;

        }
        public Dictionary<ourevent, List<participant>> GetPayymennts()
        {
            Dictionary<ourevent, List<participant>> dictionnaire = new Dictionary<ourevent, List<participant>>();

            foreach (var events in utw.getRepository<ourevent>().GetMany())
            {

                dictionnaire.Add(events, GetPayments(events));

            }

            return dictionnaire;

        }



        public void deleteParticipant(participant p)
        {
            utw.getRepository<participant>().Delete(p);
            utw.commit();
        }
        public IEnumerable<string> GetAllName()
        {
            IEnumerable<string> names = from s in utw.getRepository<participant>().GetMany()
                                        select s.user.firstName;
            //IEnumerable<string> namelist = suggestions.Where(n => n.ToLower().StartsWith(searchstring.ToLower()));
            return (names);
        }

        public int countParticipants()
        {

            IEnumerable<participant> cm = from participant in utw.getRepository<participant>().GetMany()
                                          where participant.vip.Equals(true)
                                          select participant;
            int x = cm.ToList().Count();
            return x;

            // return utw.getRepository<participant>().GetMany().Count(participant => participant.vip.Equals(true));
        }

        public void deleteParticipantById(int id)
        {
            participant p = utw.getRepository<participant>().GetById(id);
            utw.getRepository<participant>().Delete(p);
            utw.commit();
        }

        public IEnumerable<participant> getAllParticipants()
        {
            return utw.getRepository<participant>().GetMany().ToList();
        }
        public IEnumerable<payment> Getpayments()
        {
            return utw.getRepository<payment>().GetMany().ToList();
        }
        public participant getParticipantById(int i)
        {
            return utw.getRepository<participant>().GetById(i);
        }


        public IEnumerable<payment> GetPayment()
        {
            {
                return
                    utw.getRepository<payment>()
                        .GetMany()
                        .ToList()
                        .Where(payment => payment.paymentStatus.Equals("Done"));

            }
        }
        public IEnumerable<payment> getAllPayments()
        {
            return utw.getRepository<payment>().GetMany().ToList();
        }
    }
}