using SwiftMart.ProductEntity;

/// <summary>
/// Represents a washing machine product in the SwiftMart system. Inherits from the <see cref="Product"/> class and adds specific properties for washing machines.
/// </summary>
namespace SwiftMartCRM.ProductEntity
{
    public class WashingMachine : Product
    {
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the maximum load capacity of the washing machine.
        /// </summary>
        public string? MaxLoad { get; set; }

        /// <summary>
        /// Gets or sets the spin class of the washing machine (indicating spin efficiency).
        /// </summary>
        public string? SpinClass { get; set; }

        /// <summary>
        /// Gets or sets the washing class of the washing machine (indicating washing efficiency).
        /// </summary>
        public string? WashingClass { get; set; }

        /// <summary>
        /// Gets or sets the water consumption of the washing machine (measured in liters per cycle).
        /// </summary>
        public string? WaterConsumption { get; set; }

        /// <summary>
        /// Gets or sets the energy class of the washing machine (indicating energy efficiency).
        /// </summary>
        public string? EnergyClass { get; set; }
    }
}
