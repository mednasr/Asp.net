using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Evpro.Domain.Entities;

namespace Evpro.Gui.Models
{
    public class EventModel
    {
        public int idEvent { get; set; }
        public string category { get; set; }
        public string cityAdress { get; set; }
        public string countryAdress { get; set; }
        public string description { get; set; }

        [Required(ErrorMessage = "Finish date Required")]
        [DataType(DataType.DateTime)]
        public Nullable<System.DateTime> eventFinishingDate { get; set; }

        [Required(ErrorMessage = "Starting date Required")]
        [DataType(DataType.DateTime)]
        public Nullable<System.DateTime> eventStartingDate { get; set; }

        [Required(ErrorMessage = "Type Required")]
        public string eventType { get; set; }

        public string facebookEventLink { get; set; }

        [Required(ErrorMessage = "Must insert image")]
        public string image { get; set; }
        public string laltitude { get; set; }
        public string longitude { get; set; }

        [Required(ErrorMessage = "Name for the event")]
        public string name { get; set; }
        public double price { get; set; }
        public string slogan { get; set; }
        public string tag { get; set; }
        public string twitterEventLink { get; set; }
        public string video { get; set; }
        public int owner_idUser { get; set; }
        public int reward_id { get; set; }
        public virtual ICollection<comment> comments { get; set; }
        public virtual eventowner eventowner { get; set; }
        public virtual ICollection<payment> payments { get; set; }
        public virtual ICollection<satisfactionsurvey> satisfactionsurveys { get; set; }
        public virtual reward reward { get; set; }
        public virtual ICollection<task> tasks { get; set; }
        public virtual ICollection<feature> features { get; set; }
        public virtual ICollection<orgnizer> orgnizers { get; set; }
        public virtual ICollection<participant> participants { get; set; }

    }
}