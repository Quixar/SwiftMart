
/// <summary>
/// Represents the session of a customer currently logged into the SwiftMart system.
/// Provides access to the customer's ID, name, and last name.
/// Implements the Singleton design pattern to ensure only one session exists at any time.
/// </summary>
namespace SwiftMart.Sessions
{
    public class CustomerSession
    {
        private static CustomerSession instance;

        /// <summary>
        /// Gets the singleton instance of the <see cref="CustomerSession"/> class.
        /// If the instance does not exist, it will be created.
        /// </summary>
        public static CustomerSession Instance => instance ??= new CustomerSession();

        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the first name of the customer.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the last name of the customer.
        /// </summary>
        public string Lastname { get; set; }


        private CustomerSession() { }
    }
}
