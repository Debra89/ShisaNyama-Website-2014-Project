using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace DorisShisaMobileApplication
{
    public partial class Desserts : PhoneApplicationPage
    { /*! 
    Allow the visitor to view the desserts menu
       */
        public Desserts()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("you need to be registered to place an order!");

            NavigationService.Navigate(new Uri("/Register.xaml", UriKind.Relative));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("you need to be registered to place an order!");

            NavigationService.Navigate(new Uri("/Register.xaml", UriKind.Relative));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("you need to be registered to place an order!");

            NavigationService.Navigate(new Uri("/Register.xaml", UriKind.Relative));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("you need to be registered to place an order!");

            NavigationService.Navigate(new Uri("/Register.xaml", UriKind.Relative));
        }

        private void cmdback(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Menu.xaml", UriKind.Relative));
        }
    }
}