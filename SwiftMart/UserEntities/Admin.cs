using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftMart.UserEntities
{
    public class Admin : User
    {
        [Key]
        public int Id { get; set; }
        public void ModerateProduct(int productId)
        {

        }

        public void ManageUsers()
        {

        }
    }
}
