using System.ComponentModel.DataAnnotations;

/// <summary>
/// Represents a television product in the SwiftMart system. Inherits from the <see cref="Product"/> class and adds specific properties for televisions.
/// </summary>
namespace SwiftMartCRM.ProductEntity
{
    public class TV : SwiftMart.ProductEntity.Product
    {

        /// <summary>
        /// Gets or sets the screen diagonal size of the TV.
        /// </summary>
        public string? ScreenDiagonal { get; set; }

        /// <summary>
        /// Gets or sets the screen resolution of the TV.
        /// </summary>
        public string? ScreenResolution { get; set; }

        /// <summary>
        /// Gets or sets the screen frequency of the TV.
        /// </summary>
        public string? ScreenFrequency { get; set; }

        /// <summary>
        /// Gets or sets the operating system of the TV (e.g., Android TV, Tizen, WebOS).
        /// </summary>
        public string? OS { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the TV supports DVB-C (Cable television).
        /// </summary>
        public bool DVB_C { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the TV supports DVB-S2 (Satellite television).
        /// </summary>
        public bool DVB_S2 { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the TV supports DVB-T2 (Terrestrial television).
        /// </summary>
        public bool DVB_T2 { get; set; }
    }
}
