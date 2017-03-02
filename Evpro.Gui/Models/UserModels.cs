using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Evpro.Gui.Models
{
    public class UserModels
    {
        public int idUser { get; set; }
        public string firstName { get; set; }
        public string gender { get; set; }
        public string lastName { get; set; }
        public string mail { get; set; }
        public string nickName { get; set; }
        public string password { get; set; }
        public Nullable<System.DateTime> birthDate { get; set; }
        public string cityAdress { get; set; }
        public string company { get; set; }
        public string countryAdress { get; set; }
        public double laltitude { get; set; }
        public double longitude { get; set; }
        public string phoneNumber { get; set; }
        public string postalCode { get; set; }
    }
}