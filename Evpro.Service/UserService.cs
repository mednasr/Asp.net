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
  public  class UserService : MyServiceGeneric<user>, IUserService
    {
        private static IDataBaseFactory dbfac = new DataBaseFactory();

        private static IUnitOfWork utw = new UnitOfWork(dbfac);

        public UserService():base(utw)
        {

        }
        public int CountUser()
        {
            return utw.getRepository<user>().GetMany().Count();
        }
        public int CountOrgnizer()
        {
            return utw.getRepository<orgnizer>().GetMany().Count();
        }

    }
}
