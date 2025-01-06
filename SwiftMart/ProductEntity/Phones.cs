using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SwiftMart.ProductEntity
{
    class Phones : Product
    {
        public float ScreenSize { get; set; }
        public string? ScreenResolution { get; set; }
        public string? CPU { get; set; }
        public int Camera { get; set; }
        public int FrontCamera { get; set; }
        public int RAM { get; set; }
        public int Memory { get; set; }
        public bool SupportsMicroSD { get; set; }
        public bool Supports3G {  get; set; }
        public bool SupportsLTE {  get; set; }
        public bool Supports5G {  get; set; }
        public bool SupportsGPS {  get; set; }
        public bool SupportsAGPS {  get; set; }
        public bool SupportsGLONASS {  get; set; }
        public bool SupportsBDS {  get; set; }
        public int SIMCards { get; set; }
        public string? OS { get; set; }
        public string? BatteryCapacity { get; set; }
        public string? Color { get; set; }
    }
}
