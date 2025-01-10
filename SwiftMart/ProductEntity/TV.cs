using System.ComponentModel.DataAnnotations;

namespace SwiftMartCRM.ProductEntity
{
    public class TV : SwiftMart.ProductEntity.Product
    {
        
        public string? ScreenDiagonal { get; set; }
        public string? ScreenResolution { get; set; }
        public string? ScreenFrequency { get; set; }
        public string? OS { get; set; }
        public bool DVB_C { get; set; }
        public bool DVB_S2 { get; set; }
        public bool DVB_T2 { get; set; }
    }
}
