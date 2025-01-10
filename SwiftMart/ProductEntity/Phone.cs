using SwiftMart.ProductEntity;

/// <summary>
/// Represents a phone product, inheriting from the base <see cref="Product"/> class.
/// This class includes properties specific to phones, such as screen size, camera details, 
/// connectivity options (e.g., 3G, 4G, 5G), and GPS functionalities.
/// </summary>
namespace SwiftMartCRM.ProductEntity
{
    public class Phone : Product 
    {

        /// <summary>
        /// Gets or sets the unique identifier for the phone.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the screen size of the phone.
        /// Represents the diagonal size of the phone's display (e.g., 6.1 inches).
        /// </summary>
        public string? ScreenSize { get; set; }

        /// <summary>
        /// Gets or sets the screen resolution of the phone.
        /// Represents the number of pixels on the screen (e.g., 1080x2400).
        /// </summary>
        public string? ScreenResolution { get; set; }

        /// <summary>
        /// Gets or sets the CPU specification of the phone.
        /// Represents the central processing unit, such as the model and speed (e.g., Qualcomm Snapdragon 888).
        /// </summary>
        public string? CPU { get; set; }

        /// <summary>
        /// Gets or sets the camera specifications of the phone.
        /// Represents details of the phone's camera (e.g., 48 MP, dual camera).
        /// </summary>
        public string? Camera { get; set; }

        /// <summary>
        /// Gets or sets the RAM size of the phone.
        /// Represents the amount of random access memory (e.g., 8 GB).
        /// </summary>
        public string? RAM { get; set; }

        /// <summary>
        /// Gets or sets whether the phone supports a microSD card for expandable storage.
        /// </summary>
        public bool MicroSD { get; set; }

        /// <summary>
        /// Gets or sets whether the phone supports 3G connectivity.
        /// </summary>
        public bool Supports3G { get; set; }

        /// <summary>
        /// Gets or sets whether the phone supports LTE (4G) connectivity.
        /// </summary>
        public bool LTE { get; set; }

        /// <summary>
        /// Gets or sets whether the phone supports 5G connectivity.
        /// </summary>
        public bool Supports5G { get; set; }

        /// <summary>
        /// Gets or sets whether the phone has built-in GPS functionality.
        /// </summary>
        public bool GPS { get; set; }

        /// <summary>
        /// Gets or sets whether the phone supports GLONASS (Russian satellite navigation system).
        /// </summary>
        public bool GLONASS { get; set; }

        /// <summary>
        /// Gets or sets whether the phone supports BDS (BeiDou Navigation Satellite System).
        /// </summary>
        public bool BDS { get; set; }
    }
}
