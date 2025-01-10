using SwiftMart.BankCard;
using SwiftMart.DataBase;

namespace SwiftMart.Services
{
    public class CardService
    {
        private readonly Context context;

        public CardService()
        {
            context = new Context();
        }
        public void SaveCard(Card card)
        {
            context.Cards.Add(card);
            context.SaveChanges();
        }
        public List<Card> GetUserCards(int userId)
        {
            return context.Cards.Where(card => card.CustomerId == userId).ToList();
        }
    }
}
