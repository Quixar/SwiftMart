using SwiftMart.Accounts;
using SwiftMart.Commands;
using SwiftMart.DataBase;
using SwiftMart.EmailTools;
using SwiftMart.Hash;
using SwiftMart.Services;
using SwiftMart.Sessions;
using SwiftMart.UserEntities;
using SwiftMart.Validations;
using SwiftMart.WishlistEntity;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

/// <summary>
/// ViewModel for handling user login, registration, and account management processes.
/// </summary>
namespace SwiftMart.ViewModel
{
    public class UserViewModel : INotifyPropertyChanged
    {
        private int id;
        private string? name;
        private string? lastName;
        private string? email;
        private string? password;
        private string? role;
        private readonly Context context;
        private readonly CustomerValidator userValidator;
        public ICommand RegisterCommand { get; }
        public ICommand LoginCommand { get; }
        private readonly WishlistService wishlistService;
        private readonly CustomerAccountService customerAccountService;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserViewModel"/> class.
        /// </summary>
        public UserViewModel()
        {
            context = new Context();
            userValidator = new CustomerValidator(context);

            RegisterCommand = new AsyncRelayCommand(Register);
            LoginCommand = new RelayCommand(Login);
            wishlistService = new WishlistService();
            customerAccountService = new CustomerAccountService();
        }

        /// <summary>
        /// Gets or sets the user ID.
        /// </summary>
        public int Id
        {
            get => id;
            set => SetProperty(ref id, value);
        }

        /// <summary>
        /// Gets or sets the user's last name.
        /// </summary>
        public string Lastname
        {
            get => lastName;
            set => SetProperty(ref lastName, value);
        }

        /// <summary>
        /// Gets or sets the user's first name.
        /// </summary>
        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        /// <summary>
        /// Gets or sets the user's email.
        /// </summary>
        public string Email
        {
            get => email;
            set => SetProperty(ref email, value);
        }

        /// <summary>
        /// Gets or sets the user's password.
        /// </summary>
        public string Password
        {
            get => password;
            set => SetProperty(ref password, value);
        }

        /// <summary>
        /// Gets or sets the user's role.
        /// </summary>
        public string Role
        {
            get => role;
            set => SetProperty(ref role, value);
        }

        /// <summary>
        /// Event raised when a property is changed.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Raises the <see cref="PropertyChanged"/> event.
        /// </summary>
        /// <param name="propertyName">The name of the property that changed.</param>

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Sets a property's value and raises the <see cref="PropertyChanged"/> event if the value changes.
        /// </summary>
        /// <typeparam name="T">The type of the property.</typeparam>
        /// <param name="field">The backing field for the property.</param>
        /// <param name="value">The new value for the property.</param>
        /// <param name="propertyName">The name of the property.</param>
        /// <returns>True if the value changed; otherwise, false.</returns>

        protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;

            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        /// <summary>
        /// Handles the user login process.
        /// </summary>
        /// <param name="parameter">The parameter passed to the command (not used).</param>
        private void Login(object parameter)
        {
            if (userValidator.ValidateLogin(email, password, out string errorMessage))
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                OpenHomeShop();
            }
            else
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Handles the user registration process.
        /// </summary>
        private async Task Register()
        {
            if (userValidator.ValidateRegistration(Name, Lastname, Email, Password, out string errorMessage))
            {
                string hashedPassword = PasswordHasher.HashPassword(Password);

                var newCustomer = new Customer
                {
                    Name = Name,
                    Lastname = Lastname,
                    Email = Email,
                    Password = hashedPassword,
                    Role = "User"
                };

                context.Customers.Add(newCustomer);
                context.SaveChanges();

                try
                {
                    var emailService = new EmailService();
                    await emailService.Sender(Email, Name);
                    MessageBox.Show("Registration successful!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                    
                    CustomerSession.Instance.Id = newCustomer.Id;
                    CustomerSession.Instance.Name = newCustomer.Name;
                    CustomerSession.Instance.Lastname = newCustomer.Lastname;

                    wishlistService.CreateWishlist();
                    customerAccountService.CreateCustomerAccount();

                    OpenHomeShop();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error sending email: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Opens the home shop window after successful login or registration.
        /// </summary>
        private void OpenHomeShop()
        {
            var currentWindow = Application.Current.Windows.OfType<Window>().First(w => w.IsActive);
            currentWindow.Visibility = Visibility.Hidden;

            try
            {
                var homeShop = new HomeShop();
                homeShop.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening HomeShop: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
