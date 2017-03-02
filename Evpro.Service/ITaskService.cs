using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Evpro.Domain.Entities;
using Evpro.Service.Pattern;

namespace Evpro.Service
{
    public interface ITaskService : IMyServiceGeneric<task>
    {
        float Counttacheeevent(int id);
        float EventProgressDone(int id, float total);
        float EventProgressDoing(int id, float total);
        float EventProgressToDo(int id, float total);
        float AllDone();
        float AllDoing();
        float AllToDo();

    }
}
