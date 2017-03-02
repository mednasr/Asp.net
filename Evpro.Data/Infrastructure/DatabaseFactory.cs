using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Evpro.Data.Models;

namespace Evpro.Data.Infrastructure
{
    public class DataBaseFactory : Disposable, IDataBaseFactory
    {
        private eventContext context;

        public eventContext DBcontext { get { return context; } }

        public DataBaseFactory()
        {
            this.context = new eventContext();
        }

        protected override void DisposeCore()
        {
            if(DBcontext != null)
            DBcontext.Dispose();
        }
    }
}
