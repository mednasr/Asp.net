using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Evpro.Domain.Entities;

namespace Evpro.Gui.Models
{
    public class ParticipantModels:UserModels
    {
        public bool vip { get; set; }
       public IEnumerable<participant> participants { get; set; }

        public ParticipantModels()
        {
            participants=new List<participant>();
        }
    }
}