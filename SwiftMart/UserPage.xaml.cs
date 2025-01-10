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

namespace SwiftMart
{
    /// <summary>
    /// Логика взаимодействия для UserPage.xaml
    /// </summary>
    public partial class UserPage : Window
    {
        public UserPage()
        {
            InitializeComponent();
        }

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

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var homeShop = new HomeShop();
            homeShop.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var shoppingCart = new ShoppingCart();
            shoppingCart.Show();
            this.Close();
        }
    }
}
