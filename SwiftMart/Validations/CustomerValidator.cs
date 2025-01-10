using SwiftMart.DataBase;
using SwiftMart.Hash;
using SwiftMart.Sessions;

/// <summary>
/// Provides validation methods for customer registration and login processes.
/// </summary>
namespace SwiftMart.Validations
{
    public class CustomerValidator
    {
        private readonly Context context;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerValidator"/> class.
        /// </summary>
        /// <param name="context">The database context to check customer data.</param>
        public CustomerValidator(Context context)
        {
            this.context = context;
        }

        /// <summary>
        /// Validates the registration information for a new customer.
        /// </summary>
        /// <param name="name">The first name of the customer.</param>
        /// <param name="lastName">The last name of the customer.</param>
        /// <param name="email">The email of the customer.</param>
        /// <param name="password">The password of the customer.</param>
        /// <param name="errorMessage">An output parameter that contains the error message if validation fails.</param>
        /// <returns>True if all fields are valid; otherwise, false.</returns>
        public bool ValidateRegistration(string name, string lastName, string email, string password, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                errorMessage = "Please fill in all the fields.";
                return false;
            }

            if (!IsValidEmail(email))
            {
                errorMessage = "Invalid email format.";
                return false;
            }

            if (context.Customers.Any(u => u.Email == email))
            {
                errorMessage = "Email is already registered.";
                return false;
            }
            errorMessage = null;
            return true;
        }

        /// <summary>
        /// Validates the login information for an existing customer.
        /// </summary>
        /// <param name="email">The email of the customer.</param>
        /// <param name="password">The password of the customer.</param>
        /// <param name="errorMessage">An output parameter that contains the error message if validation fails.</param>
        /// <returns>True if login information is valid; otherwise, false.</returns>
        public bool ValidateLogin(string email, string password, out string errorMessage)
        {
            var customer = context.Customers.SingleOrDefault(u => u.Email == email);
            if (customer == null)
            {
                errorMessage = "User with the provided email not found.";
                return false;
            }

            if (!PasswordHasher.VerifyPassword(password, customer.Password))
            {
                errorMessage = "Incorrect password.";
                return false;
            }

            CustomerSession.Instance.Id = customer.Id;
            CustomerSession.Instance.Name = customer.Name;
            CustomerSession.Instance.Lastname = customer.Lastname;

            errorMessage = null;
            return true;
        }

        /// <summary>
        /// Checks if the given email is in a valid format.
        /// </summary>
        /// <param name="email">The email to be validated.</param>
        /// <returns>True if the email is valid; otherwise, false.</returns>
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
