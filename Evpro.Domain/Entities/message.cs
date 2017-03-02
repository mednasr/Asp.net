using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Evpro.Domain.Entities
{
    public partial class message
    {
        [Key]
        public int id { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string description { get; set; }
        public Nullable<int> id_destinataire { get; set; }
        public Nullable<int> statut { get; set; }
        public Nullable<int> orgnizer_idUser { get; set; }
        public virtual orgnizer orgnizer { get; set; }
    }
}
