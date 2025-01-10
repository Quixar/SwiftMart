using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

/// <summary>
/// Represents the user page where the user can navigate through various sections such as overview, orders, payment, and shipping address.
/// </summary>
namespace SwiftMart
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserPage"/> class.
    /// </summary>
    public partial class UserPage : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserPage"/> class.
        /// </summary>
        public UserPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the click event for the navigation buttons to switch between different sections on the page.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event data.</param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                string tag = button.Tag.ToString();

                switch (tag)
                {
                    case "Overview":
                        MainContent.Content = new OverviewControl();
                        break;
                    case "Orders":
                        MainContent.Content = new OrderControl();
                        break;
                    case "Payment":
                        MainContent.Content = new PaymentControl();
                        break;
                    case "ShippingAddress":
                        MainContent.Content = new ShippingAddressControl();
                        break;
                }
            }
        }

        /// <summary>
        /// Handles the mouse left button down event on the image to navigate back to the home shop page.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event data.</param>
        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var homeShop = new HomeShop();
            homeShop.Show();
            this.Close();
        }

        /// <summary>
        /// Handles the button click event to navigate to the shopping cart page.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event data.</param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var shoppingCart = new ShoppingCart();
            shoppingCart.Show();
            this.Close();
        }
    }
}
