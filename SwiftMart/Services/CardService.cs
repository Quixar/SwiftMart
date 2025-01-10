using SwiftMart.BankCard;
using SwiftMart.DataBase;

/// <summary>
/// Provides services for managing bank cards in the SwiftMart system.
/// Includes operations for saving and retrieving user bank cards.
/// </summary>
namespace SwiftMart.Services
{
    public class CardService
    {
        private readonly Context context;

        /// <summary>
        /// Initializes a new instance of the <see cref="CardService"/> class.
        /// </summary>
        public CardService()
        {
            context = new Context();
        }


        /// <summary>
        /// Saves a new card to the database.
        /// </summary>
        /// <param name="card">The card to be saved.</param>
        public void SaveCard(Card card)
        {
            context.Cards.Add(card);
            context.SaveChanges();
        }

        /// <summary>
        /// Retrieves a list of cards associated with a specific user.
        /// </summary>
        /// <param name="userId">The ID of the user.</param>
        /// <returns>A list of <see cref="Card"/> objects for the specified user.</returns>

        public List<Card> GetUserCards(int userId)
        {
            return context.Cards.Where(card => card.CustomerId == userId).ToList();
        }
    }
}
