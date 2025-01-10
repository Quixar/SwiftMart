using System.ComponentModel.DataAnnotations;

/// <summary>
/// Represents an address entity within the SwiftMart system.
/// Stores detailed information about a customer's address, including 
/// country, city, street name, house number, apartment number, and postal code.
/// </summary>
namespace SwiftMart.AddressEntity
{
    public class Address
    {

        /// <summary>
        /// Gets or sets the unique identifier for the address.
        /// Serves as the primary key in the database.
        /// </summary>
        [Key]
        public int Id {  get; set; }

        /// <summary>
        /// Gets or sets the identifier of the customer associated with this address.
        /// Links the address to a specific customer entity.
        /// </summary>
        public int CustomertId { get; set; }

        /// <summary>
        /// Gets or sets the name of the country for the address.
        /// </summary>
        public string? Country { get; set; }

        /// <summary>
        /// Gets or sets the name of the city for the address.
        /// </summary>
        public string? City { get; set; }

        /// <summary>
        /// Gets or sets the name of the street for the address.
        /// </summary>
        public string? StreetName { get; set; }

        /// <summary>
        /// Gets or sets the house number for the address.
        /// </summary>
        public string? HouseNumber { get; set; }

        /// <summary>
        /// Gets or sets the apartment number for the address.
        /// This is applicable if the address includes an apartment or unit.
        /// </summary>
        public string? ApartamentNumber { get; set; }

        /// <summary>
        /// Gets or sets the postal code for the address.
        /// </summary>
        public string? PostCode { get; set; }
    }
}
