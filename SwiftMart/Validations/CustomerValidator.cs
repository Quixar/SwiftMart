using SwiftMart.DataBase;
using SwiftMart.Hash;
using SwiftMart.Sessions;

namespace SwiftMart.Validations
{
    public class CustomerValidator
    {
        private readonly Context context;

        public CustomerValidator(Context context)
        {
            this.context = context;
        }

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
