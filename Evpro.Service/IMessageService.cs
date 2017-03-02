using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Evpro.Domain.Entities;
using Evpro.Service.Pattern;

namespace Evpro.Service
{
    public interface IMessageService : IMyServiceGeneric<message>
    {
        void addMessage(message m);
        IEnumerable<message> getmessagesbyiduser(int iduser);
        IEnumerable<message> getmessageenvoyer(int iduser);
        void deleteMessage(message message);
        int countMessage();
        void deleteMessageById(int id);
        IEnumerable<message> GetAllMessages();
        string getadresseMessenvoyer(int id);
        IEnumerable<orgnizer> GetOrginazer();
        message GetMessageById(int i);

        void addParticipantByIdEvent(participant participantr);
        void Update(message message);
        void Delete(message message);
        void sendmail(string adressedst, string desciption);
        string useradress(int id);
        int getuseractif();
        int countOrginzer();
        void Commit();
    }
}
