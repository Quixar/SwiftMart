using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;


/// <summary>
/// Represents the registration and login window for user authentication in the application.
/// </summary>
namespace SwiftMart
{
    /// <summary>
    /// Логика взаимодействия для RegistrationAuthorization.xaml
    /// </summary>
    public partial class RegistrationAuthorization : Window
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="RegistrationAuthorization"/> class.
        /// </summary>
        public RegistrationAuthorization()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for when the user clicks the "Register" link. Displays the registration form.
        /// </summary>
        private void Register_Click(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            LoginForm.Visibility = Visibility.Collapsed;
            RegisterForm.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Event handler for when the user clicks the "Back to Login" link. Displays the login form.
        /// </summary>
        private void BackToLogin_Click(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            RegisterForm.Visibility = Visibility.Collapsed;
            LoginForm.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Event handler for when the email text box gains focus. Clears the default text.
        /// </summary>
        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {

            if (AuthorizationEmailTextBox.Text == "Email")
            {
                AuthorizationEmailTextBox.Text = string.Empty;
                AuthorizationEmailTextBox.Foreground = new SolidColorBrush(Color.FromArgb(128, 0, 0, 0));
            }
            
        }

        /// <summary>
        /// Event handler for when the email text box loses focus. Restores the default text if the field is empty.
        /// </summary>
        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AuthorizationEmailTextBox.Text))
            {
                AuthorizationEmailTextBox.Text = "Email";
            }

        }

        /// <summary>
        /// Event handler for when the registration name text box gains focus. Clears the default text.
        /// </summary>
        private void RegistrationNameTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (RegistrationNameTextBox.Text == "Name *")
            {
                RegistrationNameTextBox.Text = string.Empty;
                AuthorizationEmailTextBox.Foreground = new SolidColorBrush(Color.FromArgb(128, 0, 0, 0));
            }
        }

        /// <summary>
        /// Event handler for when the registration name text box loses focus. Restores the default text if the field is empty.
        /// </summary>
        private void RegistrationNameTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RegistrationNameTextBox.Text))
            {
                RegistrationNameTextBox.Text = "Name *";
            }
        }

        /// <summary>
        /// Event handler for when the registration last name text box gains focus. Clears the default text.
        /// </summary>
        private void RegistrationLastNameTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (RegistrationLastNameTextBox.Text == "Lastname")
            {
                RegistrationLastNameTextBox.Text = string.Empty;
                AuthorizationEmailTextBox.Foreground = new SolidColorBrush(Color.FromArgb(128, 0, 0, 0));
            }
        }

        /// <summary>
        /// Event handler for when the registration last name text box loses focus. Restores the default text if the field is empty.
        /// </summary>
        private void RegistrationLastNameTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RegistrationLastNameTextBox.Text))
            {
                RegistrationLastNameTextBox.Text = "Lastname";
            }
        }

        /// <summary>
        /// Event handler for when the registration email text box gains focus. Clears the default text.
        /// </summary>
        private void RegistrationEmailTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (RegistrationEmailTextBox.Text == "Email *")
            {
                RegistrationEmailTextBox.Text = string.Empty;
                AuthorizationEmailTextBox.Foreground = new SolidColorBrush(Color.FromArgb(128, 0, 0, 0));
            }
        }

        /// <summary>
        /// Event handler for when the registration email text box loses focus. Restores the default text if the field is empty.
        /// </summary>
        private void RegistrationEmailTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RegistrationEmailTextBox.Text))
            {
                RegistrationEmailTextBox.Text = "Email *";
            }
        }

        /// <summary>
        /// Event handler for when the user clicks the button to confirm the password in the login form.
        /// </summary>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            VM.Password = MyPasswordBox.Password;
        }

        /// <summary>
        /// Event handler for when the user clicks the button to confirm the password in the registration form.
        /// </summary>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            VM.Password = Autorization.Password;
        }
    }
}
