using System;
using System.Collections.Generic;

namespace Evpro.Domain.Entities
{
    public partial class user
    {
        public int idUser { get; set; }
        public Nullable<System.DateTime> birthDate { get; set; }
        public string cityAdress { get; set; }
        public string company { get; set; }
        public string countryAdress { get; set; }
        public string firstName { get; set; }
        public string gender { get; set; }
        public double laltitude { get; set; }
        public string lastName { get; set; }
        public double longitude { get; set; }
        public string mail { get; set; }
        public string nickName { get; set; }
        public string password { get; set; }
        public string phoneNumber { get; set; }
        public string postalCode { get; set; }
        public virtual eventowner eventowner { get; set; }
        public virtual orgnizer orgnizer { get; set; }
        public virtual participant participant { get; set; }
    }
}
