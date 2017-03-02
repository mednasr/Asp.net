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
    public class EventownerService : MyServiceGeneric<eventowner>, IEventownerService
    {
        private static IDataBaseFactory dbfac = new DataBaseFactory();

        private static IUnitOfWork utw = new UnitOfWork(dbfac);

        public EventownerService():base(utw)
        {

        }




    }
}
