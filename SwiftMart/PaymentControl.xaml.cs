using SwiftMart.BankCard;
using SwiftMart.DataBase;
using SwiftMart.Hash;
using SwiftMart.Sessions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace SwiftMart
{
    /// <summary>
    /// Логика взаимодействия для PaymentControl.xaml
    /// </summary>
    public partial class PaymentControl : UserControl
    {
        private Context context;

        public PaymentControl()
        {
            context = new Context();
            InitializeComponent();
            DisplayUserCards();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddCardDialog.Visibility = Visibility.Visible;
        }

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
                        Date = expiryDate,
                        CVV = cvv
                    };

                    context.Cards.Add(card);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid date: " + ex.Message);
                }
            }
        }

        private void DisplayUserCards()
        {
            int userId = CustomerSession.Instance.Id; // Получаем ID текущего пользователя.
            List<Card> userCards = GetUserCards(userId); // Получаем список карт пользователя.

            // Очистим текущий список в WrapPanel перед обновлением.
            WrapPanel cardsPanel = (WrapPanel)FindName("CardsPanel");
            cardsPanel.Children.Clear();

            // Добавляем карты в WrapPanel.
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
                    Text = "VISA", // Здесь можно уточнить тип карты, если есть соответствующие данные.
                    FontSize = 12,
                    Foreground = new SolidColorBrush(Colors.Gray),
                    Margin = new Thickness(10, 0, 0, 0)
                });

                cardBorder.Child = stackPanel;
                cardsPanel.Children.Add(cardBorder);
            }

            // Добавляем кнопку для добавления новой карты.
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

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AddCardDialog.Visibility = Visibility.Collapsed;
        }

        private List<Card> GetUserCards(int userId)
        {
            return context.Cards.Where(card => card.CustomerId == userId).ToList();
        }
    }
}
