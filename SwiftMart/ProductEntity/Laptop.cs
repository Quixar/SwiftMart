using SwiftMart.ProductEntity;

/// <summary>
/// Represents a laptop product, inheriting from the base <see cref="Product"/> class.
/// This class contains properties specific to laptops, such as screen size, resolution, and hardware specifications.
/// </summary>
namespace SwiftMartCRM.ProductEntity
{
    public class Laptop : Product
    {

        /// <summary>
        /// Gets or sets the unique identifier for the laptop.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the screen size of the laptop.
        /// Represents the diagonal size of the laptop's display (e.g., 15.6 inches).
        /// </summary>
        public string? ScreenSize { get; set; }

        /// <summary>
        /// Gets or sets the screen resolution of the laptop.
        /// This represents the number of pixels on the screen (e.g., 1920x1080).
        /// </summary>
        public string? ScreenResolution { get; set; }

        /// <summary>
        /// Gets or sets the CPU specification of the laptop.
        /// Represents the central processing unit, such as the model and speed (e.g., Intel Core i7 2.8 GHz).
        /// </summary>
        public string? CPU { get; set; }

        /// <summary>
        /// Gets or sets the GPU specification of the laptop.
        /// Represents the graphics processing unit, such as the model and memory (e.g., NVIDIA GeForce GTX 1650).
        /// </summary>
        public string? GPU { get; set; }

        /// <summary>
        /// Gets or sets the RAM size of the laptop.
        /// Represents the amount of random access memory (e.g., 16 GB).
        /// </summary>
        public string? RAM { get; set; }

        /// <summary>
        /// Gets or sets the storage capacity of the laptop.
        /// Represents the amount of internal storage available (e.g., 512 GB SSD).
        /// </summary>
        public string? Memory { get; set; }

        /// <summary>
        /// Gets or sets the operating system of the laptop.
        /// Represents the software that runs the laptop (e.g., Windows 10, macOS).
        /// </summary>
        public string? OS { get; set; }
    }
}
