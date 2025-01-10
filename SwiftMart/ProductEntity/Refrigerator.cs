
using SwiftMart.ProductEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftMartCRM.ProductEntity
{
    public class Refrigerator : Product
    {
        public int Id { get; set; }
        public string? TotalVolume { get; set; }
        public string? Type { get; set; }
        public string? EnergyClass { get; set; }
        public string? Height { get; set; }
        public string? Width { get; set; }
        public string? Depth { get; set; }
    }
}
