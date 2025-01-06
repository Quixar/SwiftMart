using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace SwiftMart
{
    /// <summary>
    /// Логика взаимодействия для RegistrationAuthorization.xaml
    /// </summary>
    public partial class RegistrationAuthorization : Window
    {
        public RegistrationAuthorization()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            LoginForm.Visibility = Visibility.Collapsed;
            RegisterForm.Visibility = Visibility.Visible;
        }

        private void BackToLogin_Click(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            RegisterForm.Visibility = Visibility.Collapsed;
            LoginForm.Visibility = Visibility.Visible;
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {

            if (AuthorizationEmailTextBox.Text == "Email")
            {
                AuthorizationEmailTextBox.Text = string.Empty;
                AuthorizationEmailTextBox.Foreground = new SolidColorBrush(Color.FromArgb(128, 0, 0, 0));
            }
            
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AuthorizationEmailTextBox.Text))
            {
                AuthorizationEmailTextBox.Text = "Email";
            }

        }

        private void RegistrationNameTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (RegistrationNameTextBox.Text == "Name *")
            {
                RegistrationNameTextBox.Text = string.Empty;
                AuthorizationEmailTextBox.Foreground = new SolidColorBrush(Color.FromArgb(128, 0, 0, 0));
            }
        }

        private void RegistrationNameTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RegistrationNameTextBox.Text))
            {
                RegistrationNameTextBox.Text = "Name *";
            }
        }

        private void RegistrationLastNameTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (RegistrationLastNameTextBox.Text == "Lastname")
            {
                RegistrationLastNameTextBox.Text = string.Empty;
                AuthorizationEmailTextBox.Foreground = new SolidColorBrush(Color.FromArgb(128, 0, 0, 0));
            }
        }

        private void RegistrationLastNameTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RegistrationLastNameTextBox.Text))
            {
                RegistrationLastNameTextBox.Text = "Lastname";
            }
        }

        private void RegistrationEmailTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (RegistrationEmailTextBox.Text == "Email *")
            {
                RegistrationEmailTextBox.Text = string.Empty;
                AuthorizationEmailTextBox.Foreground = new SolidColorBrush(Color.FromArgb(128, 0, 0, 0));
            }
        }

        private void RegistrationEmailTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RegistrationEmailTextBox.Text))
            {
                RegistrationEmailTextBox.Text = "Email *";
            }
        }

        private void RegistrationAddressTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (RegistrationAddressTextBox.Text == "Address *")
            {
                RegistrationAddressTextBox.Text = string.Empty;
                AuthorizationEmailTextBox.Foreground = new SolidColorBrush(Color.FromArgb(128, 0, 0, 0));
            }
        }

        private void RegistrationAddressTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RegistrationAddressTextBox.Text))
            {
                RegistrationAddressTextBox.Text = "Address *";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            VM.Password = MyPasswordBox.Password;
            MessageBox.Show(VM.Password);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            VM.Password = Autorization.Password;
            MessageBox.Show(VM.Password);
        }
    }
}
