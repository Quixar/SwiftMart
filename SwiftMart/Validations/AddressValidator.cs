using System.Windows;

namespace SwiftMart.Validations
{
    public class AddressValidator
    {

        public void Validate(string country, string city, string streetName, string houseNumber, string postCode)
        {
            if (string.IsNullOrWhiteSpace(country) || string.IsNullOrWhiteSpace(city) ||
            string.IsNullOrWhiteSpace(streetName) || string.IsNullOrWhiteSpace(houseNumber) ||
            string.IsNullOrWhiteSpace(postCode))
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }
        }
    }
}
