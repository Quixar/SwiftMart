

using SwiftMart.ProductEntity;

namespace SwiftMartCRM.ProductEntity
{
    public class Laptop : Product
    {
        public int Id { get; set; }
        public string? ScreenSize { get; set; }
        public string? ScreenResolution { get; set; }
        public string? CPU { get; set; }
        public string? GPU { get; set; }
        public string? RAM { get; set; }
        public string? Memory { get; set; }
        public string? OS { get; set; }
    }
}
