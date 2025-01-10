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
/// Represents the window displaying the guarantee information in the SwiftMart application.
/// Provides functionality for the user to navigate back to the home shop page.
/// </summary>
namespace SwiftMart
{
    /// <summary>
    /// Логика взаимодействия для GuaranteeWindow.xaml
    /// </summary>
    public partial class GuaranteeWindow : Window
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="GuaranteeWindow"/> class.
        /// This method sets up the guarantee window where the user can view the guarantee information.
        /// </summary>
        public GuaranteeWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for mouse left button down event on an image.
        /// Navigates the user back to the home shop window.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var homeShop = new HomeShop();
            homeShop.Show();
            this.Close();
        }
    }
}
