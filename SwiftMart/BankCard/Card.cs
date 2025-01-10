using SwiftMart.UserEntities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwiftMart.BankCard
{
    public class Card
    {
        [Key]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;
        public string? NameOnCard { get; set; }
        public string? CardNumber { get; set; }
        [Column(TypeName = "date")]
        public DateOnly ExpirationDate { get; set; }
        public string? CVV { get; set; }
    }
}
