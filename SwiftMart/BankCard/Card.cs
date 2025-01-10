using SwiftMart.UserEntities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// Represents a bank card entity within the SwiftMart system.
/// Stores details about a customer's bank card, including cardholder name, card number, 
/// expiration date, and CVV code.
/// </summary>
namespace SwiftMart.BankCard
{
    public class Card
    {

        /// <summary>
        /// Gets or sets the unique identifier for the bank card.
        /// Serves as the primary key in the database.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the customer associated with this bank card.
        /// Links the card to a specific customer entity.
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the customer entity associated with this bank card.
        /// This navigation property links the card to the corresponding customer.
        /// </summary>
        public Customer Customer { get; set; } = null!;

        /// <summary>
        /// Gets or sets the name printed on the bank card.
        /// Typically the name of the cardholder.
        /// </summary>
        public string? NameOnCard { get; set; }

        /// <summary>
        /// Gets or sets the number of the bank card.
        /// This is a sensitive piece of information and should be handled securely.
        /// </summary>
        public string? CardNumber { get; set; }

        /// <summary>
        /// Gets or sets the expiration date of the bank card.
        /// Stored as a <see cref="DateOnly"/> type and formatted as a date in the database.
        /// </summary>
        [Column(TypeName = "date")]
        public DateOnly ExpirationDate { get; set; }

        /// <summary>
        /// Gets or sets the CVV (Card Verification Value) code for the bank card.
        /// This is a sensitive security feature of the card.
        /// </summary>
        public string? CVV { get; set; }
    }
}
