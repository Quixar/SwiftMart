using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftMart.UserEntities
{
    internal class User
    {
        public int Id { get; set; } 
        public string Name { get; set; } 
        public string Email { get; set; }
        public char Password { get; set; }

        public virtual void Login()
        {
            
        }

        public virtual void Logout()
        {
           
        }
    }
}