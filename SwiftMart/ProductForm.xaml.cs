using System.Windows;

namespace SwiftMart
{
    /// <summary>
    /// Логика взаимодействия для Product.xaml
    /// </summary>
    public partial class Product : Window
    {
        public Product()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ShoppingCart cart = new ShoppingCart();
            cart.Show();
            this.Close();
        }

        private void About_us_Click(object sender, RoutedEventArgs e)
        {
            var aboutUs = new AboutUsWindow();
            aboutUs.Show();
            this.Close();
        }

        private void Contact_Click(object sender, RoutedEventArgs e)
        {
            var contact = new ContactWindow();
            contact.Show();
            this.Close();
        }
        private void Delivery_payment_Click(object sender, RoutedEventArgs e)
        {
            var delivartAndPayment = new DeliveryAndPaymentWindow();
            delivartAndPayment.Show();
            this.Close();
        }
        private void Guarantees_Click(object sender, RoutedEventArgs e)
        {
            var guaratee = new GuaranteeWindow();
            guaratee.Show();
            this.Close();
        }
        private void Return_product_Click(object sender, RoutedEventArgs e)
        {
            var returnProduct = new ReturnOfProductWindow();
            returnProduct.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var userPage = new UserPage();
            userPage.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var shoppingCart = new ShoppingCart();
            shoppingCart.Show();
            this.Close();
        }

        private void Image_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var homeShop = new HomeShop();
            homeShop.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var shoppingCart = new ShoppingCart();
            shoppingCart.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var userPage = new UserPage();
            userPage.Show();
            this.Close();
        }

        private void Image_MouseLeftButtonDown_1(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var homeShop = new HomeShop();
            homeShop.Show();
            this.Close();
        }
    }
}
