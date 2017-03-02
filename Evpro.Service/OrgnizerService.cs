using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Evpro.Data.Infrastructure;
using Evpro.Domain.Entities;
using Evpro.Service.Pattern;

namespace Evpro.Service
{
 public   class OrgnizerService : MyServiceGeneric<orgnizer>, IOrgnizerService
    {
  
        private static IDataBaseFactory dbfac = new DataBaseFactory();

        private static IUnitOfWork utw = new UnitOfWork(dbfac);
       IMessageService mssr= new MessageService();

        public OrgnizerService():base(utw)
        {
          
        }


        public int nbreMsgperOrganize(int id)
        {
            var nbr = (from   msg in mssr.GetMany().ToList()      
                where msg.orgnizer_idUser == id
                select msg.orgnizer_idUser).Count();
            return nbr;


        }
    }
}
