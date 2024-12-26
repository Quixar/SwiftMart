using System.Windows;

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
            // Переход к форме регистрации
            LoginForm.Visibility = Visibility.Collapsed;
            RegisterForm.Visibility = Visibility.Visible;
        }

        private void BackToLogin_Click(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            // Переход к форме авторизации
            RegisterForm.Visibility = Visibility.Collapsed;
            LoginForm.Visibility = Visibility.Visible;
        }
    }
}
