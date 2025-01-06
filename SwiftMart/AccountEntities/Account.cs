using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftMart.Accounts
{
    public abstract class Account
    {
        public int AccountId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string AccountPhotoUrl { get; set; }
        
        public void ViewPersonalInfo()
        {

        }

        public void UpdatePersonalInfo()
        {

        }

        public void DisplayDashboard()
        {

        }
     }
}
