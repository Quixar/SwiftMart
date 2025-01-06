using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftMart.ProductEntity
{
    class Laptops : Product
    {
        public float ScreenSize { get; set; }
        public string? ScreenResolution { get; set; }
        public string? CPU {  get; set; }
        public string? RAM { get; set; }
        public string? Memory { get; set; }
        public string? GPU { get; set; }
        public bool SupportsOD { get; set; } // дисковод
        public bool SupportsLAN { get; set; }
        public bool SupportsWiFI { get; set; }
        public bool SupportsBluetooth { get; set; }
        public bool HasWebCamera { get; set; }
        public string? OS { get; set; }
        public float Weight { get; set; }
        public string? Color { get; set; }

    }
}
