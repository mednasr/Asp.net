using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Evpro.Data.Infrastructure;
using Evpro.Domain;
using Evpro.Domain.Entities;
using Evpro.Service.Pattern;

namespace Evpro.Service
{
    public class TaskService : MyServiceGeneric<task>, ITaskService
    {
        static private DataBaseFactory dbFactory = new DataBaseFactory();
        static private IUnitOfWork ut = new UnitOfWork(dbFactory);
        public TaskService() : base(ut)
        {
            ut = new UnitOfWork(dbFactory);
        }

       

        public TaskService(IUnitOfWork itw) : base(itw)
        {
        }

        public float Counttacheeevent(int id)
        {
            float res = GetMany(l => l.idEvent == id).Count();
            return res;

        }
        public float EventProgressDone(int id, float total)
        {
            float tachedone = GetMany(l => l.idEvent == id && l.status == "Done").Count();
            float resu = (tachedone / total) * 100;
            return resu;

        }

        public float EventProgressDoing(int id, float total)
        {
            float tachedoing = GetMany(l => l.idEvent == id && l.status == "Doing").Count();
            float res = (tachedoing / total) * 100;
            return res;
        }

        public float EventProgressToDo(int id, float total)
        {
            float tacheToDo = GetMany(l => l.idEvent == id && l.status == "ToDo").Count();
            float resultat = (tacheToDo / total) * 100;
            return resultat;
        }

        public float AllDone()
        {
            float total = GetMany().Count();
            float tacheDone = GetMany(l=>l.status=="Done").Count();
            float resultat= (tacheDone / total) * 100;
            return resultat;
        }

        public float AllDoing()
        {
            float total = GetMany().Count();
            float tacheDone = GetMany(l => l.status == "Doing").Count();
            float resultat = (tacheDone / total) * 100;
            return resultat;
        }

        public float AllToDo()
        {
            float total = GetMany().Count();
            float tacheDone = GetMany(l => l.status == "ToDo").Count();
            float resultat = (tacheDone / total) * 100;
            return resultat;
        }
    }

  
}
