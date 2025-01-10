using SwiftMart.AddressEntity;
using SwiftMart.DataBase;
using System.Windows;

/// <summary>
/// Provides services for managing addresses in the SwiftMart system.
/// Includes operations for saving, retrieving, and deleting addresses.
/// </summary>
namespace SwiftMart.Services
{
    public class AddressService
    {
        private readonly Context context;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressService"/> class.
        /// </summary>
        public AddressService()
        {
            context = new Context();
        }

        /// <summary>
        /// Saves a new address to the database.
        /// </summary>
        /// <param name="address">The address to be saved.</param>
        public void SaveAddress(Address address)
        {
            try
            {
                context.Addresses.Add(address);
                context.SaveChanges();
                MessageBox.Show("Address added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save address: " + ex.Message);
            }
        }

        /// <summary>
        /// Retrieves a list of addresses associated with a specific customer.
        /// </summary>
        /// <param name="id">The ID of the customer.</param>
        /// <returns>A list of <see cref="Address"/> objects for the specified customer.</returns>

        public List<Address> GetAddressesByCustomerId(int id)
        {
            return context.Addresses.Where(a => a.CustomertId == id).ToList();
        }

        /// <summary>
        /// Deletes an address from the database.
        /// </summary>
        /// <param name="address">The address to be deleted.</param>

        public void DeleteAddress(Address address)
        {
            context.Addresses.Remove(address);
            context.SaveChanges();
            MessageBox.Show("Address deleted successfully!");
        }
    }
}
