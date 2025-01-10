using System.Windows;

/// <summary>
/// Provides validation logic for address fields to ensure they are not empty or null.
/// </summary>
namespace SwiftMart.Validations
{
    public class AddressValidator
    {

        /// <summary>
        /// Validates the provided address fields to ensure they are not empty or null.
        /// </summary>
        /// <param name="country">The country of the address.</param>
        /// <param name="city">The city of the address.</param>
        /// <param name="streetName">The street name of the address.</param>
        /// <param name="houseNumber">The house number of the address.</param>
        /// <param name="postCode">The postal code of the address.</param>
        /// <returns>Shows a message box if any of the fields are empty or null.</returns>


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
