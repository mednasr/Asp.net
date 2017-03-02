using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Evpro.Domain.Entities;

namespace Evpro.Gui.Models
{
    public class MessageModels
    {   public int id { get; set; }
        public string description { get; set; }
        public int id_destinataire { get; set; }
        public IEnumerable<SelectListItem> user { get; set; }

    }
}