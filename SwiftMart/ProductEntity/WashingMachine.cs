

using SwiftMart.ProductEntity;

namespace SwiftMartCRM.ProductEntity
{
    public class WashingMachine : Product
    {
        public int Id { get; set; }
        public string? MaxLoad { get; set; }
        public string? SpinClass { get; set; }
        public string? WashingClass { get; set; }
        public string? WaterConsumption { get; set; }
        public string? EnergyClass { get; set; }
    }
}
