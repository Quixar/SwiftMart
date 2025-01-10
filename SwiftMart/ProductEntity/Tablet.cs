using SwiftMart.ProductEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Represents a tablet product in the SwiftMart system. Inherits from the <see cref="Product"/> class and adds specific properties for tablets.
/// </summary>
namespace SwiftMartCRM.ProductEntity
{
    public class Tablet : Product
    {

        /// <summary>
        /// Gets or sets the unique identifier for the tablet.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the screen size of the tablet.
        /// </summary>
        public string? ScreenSize { get; set; }

        /// <summary>
        /// Gets or sets the screen resolution of the tablet.
        /// </summary>
        public string? ScreenResolution { get; set; }

        /// <summary>
        /// Gets or sets the CPU of the tablet.
        /// </summary>
        public string? CPU { get; set; }

        /// <summary>
        /// Gets or sets the camera specifications of the tablet.
        /// </summary>
        public string? Camera { get; set; }

        /// <summary>
        /// Gets or sets the RAM size of the tablet.
        /// </summary>
        public string? RAM { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the tablet supports MicroSD cards.
        /// </summary>
        public bool MicroSD { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the tablet supports 3G.
        /// </summary>
        public bool Supports3G { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the tablet supports LTE.
        /// </summary>
        public bool LTE { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the tablet supports 5G.
        /// </summary>
        public bool Supports5G { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the tablet supports GPS.
        /// </summary>
        public bool GPS { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the tablet supports GLONASS.
        /// </summary>
        public bool GLONASS { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the tablet supports BDS (BeiDou Navigation Satellite System).
        /// </summary>
        public bool BDS { get; set; }
    }
}
