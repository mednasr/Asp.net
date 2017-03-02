using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Evpro.Service.Pattern;
using Evpro.Domain.Entities;
using Evpro.Data.Infrastructure;
using SendGrid;

namespace Evpro.Service
{
    public class MessageService : MyServiceGeneric<message>, IMessageService
    {
        private static IDataBaseFactory dbfac = new DataBaseFactory();

        private static IUnitOfWork utw = new UnitOfWork(dbfac);
        public MessageService() : base(utw)
        {
        }
        IUserService us = new UserService();
        public void addMessage(message m)
        {
            utw.getRepository<message>().Add(m);
            utw.commit();
        }
        public IEnumerable<message> getmessagesbyiduser(int iduser)
        {
            return utw.getRepository<message>().GetMany(x => x.id_destinataire.Value == iduser);
        }
        public IEnumerable<message> getmessageenvoyer(int iduser)
        {
            return utw.getRepository<message>().GetMany(x => x.orgnizer_idUser.Value == iduser);
        }

        public void deleteMessage(message message)
        {
            utw.getRepository<message>().Delete(message);
            utw.commit();
        }

        public int countMessage()
        {
            return utw.getRepository<message>().GetMany().Count();
        }
        public int countOrginzer()
        {
            return utw.getRepository<orgnizer>().GetMany().Count();
        }


        public void deleteMessageById(int id)
        {
            message m = utw.getRepository<message>().GetById(id);
            utw.getRepository<message>().Delete(m);
            utw.commit();
        }

        public IEnumerable<message> GetAllMessages()
        {
            return utw.getRepository<message>().GetMany().ToList();
        }
        public IEnumerable<orgnizer> GetOrginazer()
        {
            return utw.getRepository<orgnizer>().GetMany().ToList();
        }

        public message GetMessageById(int i)
        {
            return utw.getRepository<message>().GetById(i);
        }



        public string getadresseMessenvoyer(int id)
        {
            string rs = (from satis in us.GetMany().ToList()
                         join msg in this.GetMany().ToList() on satis.idUser equals msg.idUser
                         where satis.idUser == id
                         select satis.mail).First();
            return rs;
        }
        public int getuseractif()
        {
            int rs = (from satis in this.GetAllMessages().ToList()

                      group satis by satis.orgnizer_idUser into satisGroup

                      // where satis.orgnizer_idUser == 1
                      select satisGroup.Key).Count();
            return rs;
        }
        public void update(message m)
        {

            utw.getRepository<message>().Update(m);
            utw.commit();
        }

        public void addParticipantByIdEvent(participant participantr)
        {
            // ut.ParticipantRepository.Add().;
        }
        public void Update(message message)
        {
            utw.getRepository<message>().Update(message);
            utw.commit();
        }
        public void Delete(message message)
        {
            utw.getRepository<message>().Delete(message);
        }

        public void sendmail(string adressedst, string desciption)
        {
            SendGridMessage myMessage = new SendGridMessage();
            myMessage.AddTo(adressedst);
            myMessage.From = new MailAddress("Orgonaizer@event.tn", "Event-vent");
            myMessage.Subject = "Message";
            myMessage.Text = desciption;

            // Create credentials, specifying your user name and password.
            var credentials = new NetworkCredential("khalilbenhassine", "khalilo123456789");

            // Create an Web transport for sending email.
            var transportWeb = new Web(credentials);


            // Send the email, which returns an awaitable task.
            transportWeb.DeliverAsync(myMessage);
        }

        public string useradress(int id)
        {
            string rs = (from vnd in us.GetMany()
                         where vnd.idUser == id
                         select vnd.mail).First().ToString();
            return rs;
        }

        public void Commit()
        {

            utw.commit();

        }


        public IEnumerable<participant> GetMany(Expression<Func<participant, bool>> condition = null, Expression<Func<participant, bool>> orderBy = null)
        {
            throw new NotImplementedException();
        }

        public void DeletebyCondition(Expression<Func<participant, bool>> condition)
        {
            throw new NotImplementedException();
        }

        public void commit()
        {
            throw new NotImplementedException();
        }




        public void Add(message t)
        {
            utw.getRepository<message>().Add(t);
            utw.commit();
        }




        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }

}
