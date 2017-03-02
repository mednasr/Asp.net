using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Evpro.Domain.Entities;

namespace Evpro.Gui.Models
{
    public class OrgnizerModel:UserModels
    {
        
        public float rating { get; set; }
        public int nbrmsg { get; set; }
        public Int32 idUser { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }


    }
}