using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Evpro.Domain.Entities;

namespace Evpro.Gui.Models
{
    public class CostumeModel
    {
        public List<EventModel> Ev { get; set; }
        public EventModel A { get; set; }
        public EventModel B { get; set; }

        public List<reward> Re { get; set; }
        public List<eventowner> Eo { get; set; }
    }
}