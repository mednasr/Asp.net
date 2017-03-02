using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Evpro.Domain.Entities;

namespace Evpro.Gui.Models
{
    public class TaskModel 
    {
        public System.DateTime deadLineTask { get; set; }
        public string description { get; set; }
       
        public int id { get; set; }
        public int idEvent { get; set; }
        public int idOrgnizer { get; set; }
        public System.DateTime startTask { get; set; }
        public string status { get; set; }
        public string EventName { get; set; }
        public string OrgnizerName { get; set; }
        public string Eventowner { get; set; }
        public IEnumerable<ourevent> listidevent { get; set; }
        public virtual orgnizer orgnizer { get; set; }
        public virtual ourevent ourevent { get; set; }
       
    }
}