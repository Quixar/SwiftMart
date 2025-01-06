using SwiftMart.Products;
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
    /// Логика взаимодействия для HomeShop.xaml
    /// </summary>
    public partial class HomeShop : Window
    {
        public HomeShop()
        {
            InitializeComponent();
        }

        private void Border_MouseEnter(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Product Page");
            Product productWindow = new Product();
            productWindow.Show();

            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Bucket");
        }

        private void About_us_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Contact_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Delivery_payment_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Guarantees_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Return_product_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var userPage = new UserPage();
            userPage.Show();
            this.Close();
        }
    }
}
