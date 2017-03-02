using System;
using System.Collections.Generic;

namespace Evpro.Domain.Entities
{
    public partial class feature
    {
        public feature()
        {
            this.ourevents = new List<ourevent>();
        }

        public int id { get; set; }
        public string feature1 { get; set; }
        public string logo { get; set; }
        public virtual ICollection<ourevent> ourevents { get; set; }
    }
}
