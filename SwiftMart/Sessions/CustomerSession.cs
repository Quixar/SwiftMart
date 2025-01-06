using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftMart.Sessions
{
    public class CustomerSession
    {
        private static CustomerSession instance;
        public static CustomerSession Instance => instance ??= new CustomerSession();

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        
        private CustomerSession() { }
    }
}
