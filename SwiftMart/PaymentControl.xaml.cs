using SwiftMart.BankCard;
using SwiftMart.Hash;
using SwiftMart.Services;
using SwiftMart.Sessions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

/// <summary>
/// User control for handling payment-related actions such as adding and displaying bank cards.
/// </summary>
namespace SwiftMart
{
    /// <summary>
    /// Логика взаимодействия для PaymentControl.xaml
    /// </summary>
    public partial class PaymentControl : UserControl
    {
        private CardService cardService;

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentControl"/> class.
        /// Initializes the card service and displays the user's saved cards.
        /// </summary>
        public PaymentControl()
        {
            cardService = new CardService();
            InitializeComponent();
            DisplayUserCards();
        }

        /// <summary>
        /// Event handler for when the user clicks the "Add New Card" button. Displays the Add Card dialog.
        /// </summary>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddCardDialog.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Event handler for when the user clicks the "Save Card" button. Saves the entered card details to the service.
        /// If valid, the card is saved and displayed in the user's card list.
        /// </summary>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddCardDialog.Visibility = Visibility.Collapsed;

            string? selectedMonth = (MM.SelectedItem as ComboBoxItem)?.Content.ToString();
            string? selectedYear = (YY.SelectedItem as ComboBoxItem)?.Content.ToString();

            if (int.TryParse(selectedMonth, out int month) && int.TryParse(selectedYear, out int year))
            {
                try
                {
                    DateOnly expiryDate = new DateOnly(year, month, 1);

                    string cvv = PasswordHasher.HashPassword(CVV.Text);

                    Card card = new Card()
                    {
                        CustomerId = CustomerSession.Instance.Id,
                        CardNumber = CardNumber.Text,
                        NameOnCard = NameOnCard.Text,
                        ExpirationDate = expiryDate,
                        CVV = cvv
                    };

                    cardService.SaveCard(card);
                    DisplayUserCards();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid date: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Displays all the user's saved cards in a WrapPanel. Each card is shown with the last four digits and the card type (e.g., VISA).
        /// Also provides an option to add a new card.
        /// </summary>
        private void DisplayUserCards()
        {
            var userCards = cardService.GetUserCards(CustomerSession.Instance.Id);

            WrapPanel cardsPanel = (WrapPanel)FindName("CardsPanel");
            cardsPanel.Children.Clear();

            foreach (var card in userCards)
            {
                var cardBorder = new Border
                {
                    Width = 200,
                    Height = 100,
                    Background = new SolidColorBrush(Color.FromRgb(245, 245, 245)),
                    BorderBrush = new SolidColorBrush(Color.FromRgb(204, 204, 204)),
                    BorderThickness = new Thickness(1),
                    CornerRadius = new CornerRadius(5),
                    Margin = new Thickness(10)
                };

                var stackPanel = new StackPanel();
                stackPanel.Children.Add(new TextBlock
                {
                    Text = $"**** {card.CardNumber.Substring(card.CardNumber.Length - 4)}",
                    FontWeight = FontWeights.Bold,
                    FontSize = 14,
                    Margin = new Thickness(10)
                });

                stackPanel.Children.Add(new TextBlock
                {
                    Text = "VISA",
                    FontSize = 12,
                    Foreground = new SolidColorBrush(Colors.Gray),
                    Margin = new Thickness(10, 0, 0, 0)
                });

                cardBorder.Child = stackPanel;
                cardsPanel.Children.Add(cardBorder);
            }

            var addCardBorder = new Border
            {
                Width = 200,
                Height = 100,
                Background = new SolidColorBrush(Color.FromRgb(245, 245, 245)),
                BorderBrush = new SolidColorBrush(Color.FromRgb(204, 204, 204)),
                BorderThickness = new Thickness(1),
                CornerRadius = new CornerRadius(5),
                Margin = new Thickness(10)
            };

            var addCardButton = new Button
            {
                Content = "+ Add new Card",
                Background = Brushes.Transparent,
                BorderThickness = new Thickness(0),
                FontSize = 16,
                Foreground = Brushes.Black
            };

            addCardButton.Click += Button_Click;
            addCardBorder.Child = addCardButton;

            cardsPanel.Children.Add(addCardBorder);
        }

        /// <summary>
        /// Event handler for when the user clicks the "Cancel" button in the Add Card dialog. Hides the Add Card dialog.
        /// </summary>
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AddCardDialog.Visibility = Visibility.Collapsed;
        }
    }
}
