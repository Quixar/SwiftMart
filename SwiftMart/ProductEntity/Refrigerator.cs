
using SwiftMart.ProductEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Represents a refrigerator product, inheriting from the base <see cref="Product"/> class.
/// This class adds specific properties related to refrigerators, such as volume, type, and energy class.
/// </summary>
namespace SwiftMartCRM.ProductEntity
{
    public class Refrigerator : Product
    {

        /// <summary>
        /// Gets or sets the unique identifier for the refrigerator.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the total volume of the refrigerator.
        /// This represents the internal storage capacity of the refrigerator (e.g., "350L").
        /// </summary>
        public string? TotalVolume { get; set; }

        /// <summary>
        /// Gets or sets the type of the refrigerator.
        /// This can specify the type of refrigerator, such as "French door", "Side-by-side", etc.
        /// </summary>
        public string? Type { get; set; }

        /// <summary>
        /// Gets or sets the energy class of the refrigerator.
        /// This specifies the energy efficiency rating, such as "A++", "A+", etc.
        /// </summary>
        public string? EnergyClass { get; set; }

        /// <summary>
        /// Gets or sets the height of the refrigerator.
        /// This is the height dimension of the refrigerator (e.g., "180cm").
        /// </summary>
        public string? Height { get; set; }

        /// <summary>
        /// Gets or sets the width of the refrigerator.
        /// This is the width dimension of the refrigerator (e.g., "70cm").
        /// </summary>
        public string? Width { get; set; }

        /// <summary>
        /// Gets or sets the depth of the refrigerator.
        /// This is the depth dimension of the refrigerator (e.g., "75cm").
        /// </summary>
        public string? Depth { get; set; }
    }
}
