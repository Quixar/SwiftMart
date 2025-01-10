using System.ComponentModel.DataAnnotations;

namespace SwiftMart.AddressEntity
{
    public class Address
    {
        [Key]
        public int Id {  get; set; }
        public int CustomertId { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? StreetName { get; set; }
        public string? HouseNumber { get; set; }
        public string? ApartamentNumber { get; set; }
        public string? PostCode { get; set; }
    }
}
