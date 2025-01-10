

using SwiftMart.ProductEntity;

namespace SwiftMartCRM.ProductEntity
{
    public class Phone : Product 
    {
        public int Id { get; set; }
        public string? ScreenSize { get; set; }
        public string? ScreenResolution { get; set; }
        public string? CPU { get; set; }
        public string? Camera { get; set; }
        public string? RAM { get; set; }
        public bool MicroSD { get; set; }
        public bool Supports3G { get; set; }
        public bool LTE { get; set; }
        public bool Supports5G { get; set; }
        public bool GPS { get; set; }
        public bool GLONASS { get; set; }
        public bool BDS { get; set; }
    }
}
