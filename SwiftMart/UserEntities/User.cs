using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftMart.UserEntities
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Lastname { get; set; }
        public string? Email { get; set; }
        public char Password { get; set; }
        public string? Address { get; set; }
        public string? Role { get; set; }
    }
}
