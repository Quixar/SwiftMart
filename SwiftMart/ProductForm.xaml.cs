using System.Windows;

/// <summary>
/// Represents the product window where users can view product details and navigate to other sections like shopping cart, user page, etc.
/// </summary>
namespace SwiftMart
{
    /// <summary>
    /// Логика взаимодействия для Product.xaml
    /// </summary>
    public partial class Product : Window
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Product"/> class.
        /// </summary>
        public Product()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for when the user clicks the "Add to Cart" button. Opens the shopping cart window.
        /// </summary>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ShoppingCart cart = new ShoppingCart();
            cart.Show();
            this.Close();
        }

        /// <summary>
        /// Event handler for when the user clicks the "About Us" button. Opens the About Us window.
        /// </summary>
        private void About_us_Click(object sender, RoutedEventArgs e)
        {
            var aboutUs = new AboutUsWindow();
            aboutUs.Show();
            this.Close();
        }

        /// <summary>
        /// Event handler for when the user clicks the "Contact" button. Opens the Contact window.
        /// </summary>
        private void Contact_Click(object sender, RoutedEventArgs e)
        {
            var contact = new ContactWindow();
            contact.Show();
            this.Close();
        }

        /// <summary>
        /// Event handler for when the user clicks the "Delivery and Payment" button. Opens the Delivery and Payment window.
        /// </summary>
        private void Delivery_payment_Click(object sender, RoutedEventArgs e)
        {
            var delivartAndPayment = new DeliveryAndPaymentWindow();
            delivartAndPayment.Show();
            this.Close();
        }

        /// <summary>
        /// Event handler for when the user clicks the "Guarantees" button. Opens the Guarantees window.
        /// </summary>
        private void Guarantees_Click(object sender, RoutedEventArgs e)
        {
            var guaratee = new GuaranteeWindow();
            guaratee.Show();
            this.Close();
        }

        /// <summary>
        /// Event handler for when the user clicks the "Return Product" button. Opens the Return of Product window.
        /// </summary>
        private void Return_product_Click(object sender, RoutedEventArgs e)
        {
            var returnProduct = new ReturnOfProductWindow();
            returnProduct.Show();
            this.Close();
        }

        /// <summary>
        /// Event handler for when the user clicks the "User Page" button. Opens the User Page window.
        /// </summary>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var userPage = new UserPage();
            userPage.Show();
            this.Close();
        }

        /// <summary>
        /// Event handler for when the user clicks the "Shopping Cart" button. Opens the Shopping Cart window.
        /// </summary>
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var shoppingCart = new ShoppingCart();
            shoppingCart.Show();
            this.Close();
        }

        /// <summary>
        /// Event handler for when the user clicks on the home shop logo. Opens the Home Shop window.
        /// </summary>
        private void Image_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var homeShop = new HomeShop();
            homeShop.Show();
            this.Close();
        }

        // <summary>
        /// Event handler for when the user clicks the "Shopping Cart" button again. Opens the Shopping Cart window.
        /// </summary>
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var shoppingCart = new ShoppingCart();
            shoppingCart.Show();
            this.Close();
        }

        /// <summary>
        /// Event handler for when the user clicks the "User Page" button again. Opens the User Page window.
        /// </summary>
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var userPage = new UserPage();
            userPage.Show();
            this.Close();
        }

        /// <summary>
        /// Event handler for when the user clicks on the home shop logo again. Opens the Home Shop window.
        /// </summary>
        private void Image_MouseLeftButtonDown_1(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var homeShop = new HomeShop();
            homeShop.Show();
            this.Close();
        }
    }
}
