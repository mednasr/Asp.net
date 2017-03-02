using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Evpro.Data.Models;

namespace Evpro.Data.Infrastructure
{
    public interface IDataBaseFactory
    {
        eventContext DBcontext {get; }
    }
}
