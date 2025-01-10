using SwiftMart.ProductEntity;
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
/// Represents the home page of the SwiftMart application, where users can navigate to product details, their shopping cart, and their user page.
/// </summary>
namespace SwiftMart
{
    /// <summary>
    /// Логика взаимодействия для HomeShop.xaml
    /// </summary>
    public partial class HomeShop : Window
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeShop"/> class.
        /// This method sets up the home page window where the user can navigate through the application.
        /// </summary>
        public HomeShop()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for when the mouse enters a <see cref="Border"/> element.
        /// Opens the product details page.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void Border_MouseEnter(object sender, MouseEventArgs e)
        {
            Product productWindow = new Product();
            productWindow.Show();
            this.Close();
        }

        /// <summary>
        /// Event handler for the button click event. Currently does nothing.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        /// <summary>
        /// Event handler for mouse left button down event on a <see cref="Border"/> element.
        /// Displays a message box with the text "Bucket".
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //MessageBox.Show("Bucket");
        }

        /// <summary>
        /// Event handler for navigating to the user page.
        /// Opens the <see cref="UserPage"/> window and closes the current window.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var userPage = new UserPage();
            userPage.Show();
            this.Close();
        }

        /// <summary>
        /// Event handler for navigating to the shopping cart page.
        /// Opens the <see cref="ShoppingCart"/> window and closes the current window.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var shoppingCart = new ShoppingCart();
            shoppingCart.Show();
            this.Close();
        }
    }
}
