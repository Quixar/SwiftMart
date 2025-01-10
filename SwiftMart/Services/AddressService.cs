using SwiftMart.AddressEntity;
using SwiftMart.DataBase;
using System.Windows;

namespace SwiftMart.Services
{
    public class AddressService
    {
        private readonly Context context;

        public AddressService()
        {
            context = new Context();
        }

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

        public List<Address> GetAddressesByCustomerId(int id)
        {
            return context.Addresses.Where(a => a.CustomertId == id).ToList();
        }

        public void DeleteAddress(Address address)
        {
            context.Addresses.Remove(address);
            context.SaveChanges();
            MessageBox.Show("Address deleted successfully!");
        }
    }
}
