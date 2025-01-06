using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftMart.ProductEntity
{
    class TVs : Product
    {
        public float ScreenDiagonal { get; set; }
        public string? ScreenResolution { get; set; }
        public int ScreenFrequency { get; set; }
        public string? DisplayTechnology { get; set; }
        public string? OS { get; set; }
        public string? DVB { get; set; }
        public bool SupportsSmartTV { get; set; }
        public bool SupportsBluetooth { get; set; }

    }
}
