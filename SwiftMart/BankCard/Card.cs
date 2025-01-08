namespace SwiftMart.BankCard
{
    public class Card
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string? NameOnCard { get; set; }
        public string? CardNumber { get; set; }
        public DateOnly Date { get; set; }
        public string? CVV { get; set; }
    }
}
