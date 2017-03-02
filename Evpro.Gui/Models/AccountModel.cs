using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Evpro.Gui.Models
{
    public class AccountModel
    {
        private  List<Account> listAccounts= new List<Account>();

        public AccountModel()
        {
            listAccounts.Add(new Account{Username = "Admin",Password = "Admin",Roles = new string[] {"superAdmin","admin","employee"}});

  
        }

        public Account find(string username)
        {
            return listAccounts.Where(acc => acc.Username.Equals(username)).FirstOrDefault();

        }

        public Account login(string username, string password)
        {
            return listAccounts.Where(acc=>acc.Username.Equals(username)&& acc.Password.Equals(password)).FirstOrDefault();
        }
    }
}