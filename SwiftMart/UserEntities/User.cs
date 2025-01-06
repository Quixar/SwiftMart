
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace SwiftMart.UserEntities
{
    [Index(nameof(Email), IsUnique = true)]
    public partial class User
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Lastname { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Address { get; set; }
        public string? Role { get; set; }
    }
}
