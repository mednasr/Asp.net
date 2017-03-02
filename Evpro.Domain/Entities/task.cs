using System;
using System.Collections.Generic;

namespace Evpro.Domain.Entities
{
    public partial class task
    {
        public System.DateTime deadLineTask { get; set; }
        public string description { get; set; }
        public int id { get; set; }
        public int idEvent { get; set; }
        public int idOrgnizer { get; set; }
        public System.DateTime startTask { get; set; }
        public string status { get; set; }
        public virtual orgnizer orgnizer { get; set; }
        public virtual ourevent ourevent { get; set; }
    }
}
