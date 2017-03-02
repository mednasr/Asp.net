using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Evpro.Domain.Entities;

namespace Evpro.Gui.Models
{
    public class RewardModel
    {
     
        public int id { get; set; }
        public string description { get; set; }
        public virtual IEnumerable<ourevent> ourevents { get; set; }
        public virtual IEnumerable<participant> participants { get; set; }
        public RewardModel()
        {
            this.ourevents = new List<ourevent>();
            this.participants = new List<participant>();
        }

    }
}