using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftMart.OrderEntities
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerID { get; set; }
        public List<int> ProductID { get; set; }
        public enum Status;
        public string DelaveryAddress { get; set; }
        public DateTime CreatedDate { get; set; }
        public float TotalPrice { get; set; }
    }
}
