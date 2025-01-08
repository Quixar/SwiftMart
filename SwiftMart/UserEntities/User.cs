
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace SwiftMart.UserEntities
{
   
    public partial class User
    {
        public string? Name { get; set; }
        public string? Lastname { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }
    }
}
