using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Evpro.Domain.Entities;

namespace Evpro.Gui.Models
{
    public class OureventModel
    {
        public OureventModel()
        {
            this.comments = new List<comment>();
            this.payments = new List<payment>();
            this.satisfactionsurveys = new List<satisfactionsurvey>();
            this.tasks = new List<task>();
            this.features = new List<feature>();
            this.orgnizers = new List<orgnizer>();
            this.participants = new List<participant>();
        }
        public int idEvent { get; set; }
        public string category { get; set; }
        public string cityAdress { get; set; }
        public string countryAdress { get; set; }
        public string description { get; set; }
        public Nullable<System.DateTime> eventFinishingDate { get; set; }
        public Nullable<System.DateTime> eventStartingDate { get; set; }
        public string eventType { get; set; }
        public string facebookEventLink { get; set; }
        public byte[] image { get; set; }
        public double laltitude { get; set; }
        public double longitude { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public string slogan { get; set; }
        public string tag { get; set; }
        public string twitterEventLink { get; set; }
        public string video { get; set; }
        public Nullable<int> owner_idUser { get; set; }
        public Nullable<int> reward_id { get; set; }
        public virtual ICollection<comment> comments { get; set; }
        public virtual eventowner eventowner { get; set; }
        public virtual ICollection<payment> payments { get; set; }
        public virtual ICollection<satisfactionsurvey> satisfactionsurveys { get; set; }
        public virtual reward reward { get; set; }
        public virtual ICollection<task> tasks { get; set; }
        public virtual ICollection<feature> features { get; set; }
        public virtual ICollection<orgnizer> orgnizers { get; set; }
        public virtual ICollection<participant> participants { get; set; }
        public string Done_task { get; set; }
        public string Doing_task { get; set; }
        public string ToDo_task { get; set; }
        public float Donetask { get; set; }
        public float Doingtask { get; set; }
        public float ToDotask { get; set; }

    }
}