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
/// Represents the shopping cart window where users can review and manage their selected products before checkout.
/// </summary>
namespace SwiftMart
{
    /// <summary>
    /// Логика взаимодействия для ShoppingCart.xaml
    /// </summary>
    public partial class ShoppingCart : Window
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ShoppingCart"/> class.
        /// </summary>
        public ShoppingCart()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the mouse left button down event on the image to navigate back to the home shop page.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param
        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var homeShop = new HomeShop();
            homeShop.Show();
            this.Close();
        }

        /// <summary>
        /// Handles the button click event to navigate to the user page.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var userPage = new UserPage();
            userPage.Show();
            this.Close();
        }

        /// <summary>
        /// Handles the second button click event to navigate to the user page.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event data.</param>

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var userPage = new UserPage();
            userPage.Show();
            this.Close();
        }
    }
}
