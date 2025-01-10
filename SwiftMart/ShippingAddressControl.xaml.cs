﻿using SwiftMart.DataBase;
using SwiftMart.Services;
using SwiftMart.Sessions;
using SwiftMart.Validations;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace SwiftMart
{
    /// <summary>
    /// Логика взаимодействия для ShippingAddressControl.xaml
    /// </summary>
    public partial class ShippingAddressControl : UserControl
    {
        private readonly Context context;
        private readonly AddressService addressService;
        private AddressValidator addressValidator;

        public ShippingAddressControl()
        {
            addressValidator = new AddressValidator();
            context = new Context();
            addressService = new AddressService();
            InitializeComponent();
            DisplayUserAddresses();
        }

        private void ResetAddressForm()
        {
            Country.Text = string.Empty;
            City.Text = string.Empty;
            StreetName.Text = string.Empty;
            HouseNumber.Text = string.Empty;
            ApartamentNumber.Text = string.Empty;
            PostCode.Text = string.Empty;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ResetAddressForm();
            AddAddressDialog.Visibility = Visibility.Visible;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            addressValidator.Validate(Country.Text, City.Text, StreetName.Text, HouseNumber.Text, PostCode.Text);

            var address = new AddressEntity.Address
            {
                Country = Country.Text,
                ApartamentNumber = ApartamentNumber.Text,
                City = City.Text,
                PostCode = PostCode.Text,
                StreetName = StreetName.Text,
                HouseNumber = HouseNumber.Text,
                CustomertId = CustomerSession.Instance.Id
            };

            addressService.SaveAddress(address);

            AddAddressDialog.Visibility = Visibility.Collapsed;
            DisplayUserAddresses();
        }

        private void DisplayUserAddresses()
        {
            var userAddresses = addressService.GetAddressesByCustomerId(CustomerSession.Instance.Id);

            WrapPanel addressesPanel = (WrapPanel)FindName("AddressesPanel");
            addressesPanel.Children.Clear();

            foreach (var address in userAddresses)
            {
                var addressBorder = new Border
                {
                    Width = 300,
                    Height = 150,
                    Background = new SolidColorBrush(Color.FromRgb(245, 245, 245)),
                    BorderBrush = new SolidColorBrush(Color.FromRgb(204, 204, 204)),
                    BorderThickness = new Thickness(1),
                    CornerRadius = new CornerRadius(5),
                    Margin = new Thickness(10)
                };

                var stackPanel = new StackPanel { Margin = new Thickness(10) };

                stackPanel.Children.Add(new TextBlock
                {
                    Text = $"{address.StreetName}, {address.City}",
                    FontWeight = FontWeights.Bold,
                    FontSize = 14
                });

                stackPanel.Children.Add(new TextBlock
                {
                    Text = $"{address.Country}, {address.PostCode}",
                    FontSize = 12,
                    Foreground = new SolidColorBrush(Colors.Gray)
                });

                var buttonPanel = new StackPanel
                {
                    Orientation = Orientation.Horizontal,
                    HorizontalAlignment = HorizontalAlignment.Right,
                    Margin = new Thickness(0, 10, 0, 0)
                };

                var editButton = new Button
                {
                    Content = "Edit",
                    Margin = new Thickness(5)
                };
                editButton.Click += (s, e) => EditAddress(address);

                var deleteButton = new Button
                {
                    Content = "Delete",
                    Margin = new Thickness(5)
                };
                deleteButton.Click += (s, e) => DeleteAddress(address);

                buttonPanel.Children.Add(editButton);
                buttonPanel.Children.Add(deleteButton);
                stackPanel.Children.Add(buttonPanel);

                addressBorder.Child = stackPanel;
                addressesPanel.Children.Add(addressBorder);
            }

            var addAddressBorder = new Border
            {
                Width = 300,
                Height = 150,
                Background = new SolidColorBrush(Color.FromRgb(245, 245, 245)),
                BorderBrush = new SolidColorBrush(Color.FromRgb(204, 204, 204)),
                BorderThickness = new Thickness(1),
                CornerRadius = new CornerRadius(5),
                Margin = new Thickness(10)
            };

            var addAddressButton = new Button
            {
                Content = "+ Add new Address",
                Background = Brushes.Transparent,
                BorderThickness = new Thickness(0),
                FontSize = 16,
                Foreground = Brushes.Black
            };
            addAddressButton.Click += Button_Click;

            addAddressBorder.Child = addAddressButton;
            addressesPanel.Children.Add(addAddressBorder);
        }
        private void EditAddress(AddressEntity.Address address)
        {
            Country.Text = address.Country;
            City.Text = address.City;
            StreetName.Text = address.StreetName;
            HouseNumber.Text = address.HouseNumber;
            ApartamentNumber.Text = address.ApartamentNumber;
            PostCode.Text = address.PostCode;

            AddAddressDialog.Visibility = Visibility.Visible;
        }
        private void DeleteAddress(AddressEntity.Address address)
        {
            if (MessageBox.Show("Are you sure you want to delete this address?", "Confirm Delete", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                addressService.DeleteAddress(address);
                DisplayUserAddresses();
            }
        }
    }
}
