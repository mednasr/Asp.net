using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Evpro.Gui.Models
{
    public class Account
    { [Display(Name = "Username")]
        public string Username
        {
            set; get;
        }
        [Display(Name = "Password")]
        public string Password
        {
            set; get;
        }
        public string [] Roles
        {
            set; get;
        }
    }
}