using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Evpro.Domain.Entities;

namespace Evpro.Gui.Models
{
    public class CustomersViewModel
    {
        public List<participant> Customers { get; set; }
        public participant SelectedCustomer { get; set; }
        public string DisplayMode { get; set; }
    }
}