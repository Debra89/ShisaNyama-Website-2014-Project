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
    public partial class Menu : PhoneApplicationPage
    { /*! 
    Allow the visitor to view the menu
       */
        public Menu()
        {
            InitializeComponent();
        }

        private void lblRegister_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Register.xaml", UriKind.Relative));
        }

        private void lblSignIn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Login.xaml", UriKind.Relative));
        }

       
        private void cmdbreakfast(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Breakfast.xaml", UriKind.Relative));
        }

        private void cmddesserts(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Desserts.xaml", UriKind.Relative));
        }

        private void cmdsandwiches(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Sandwiches.xaml", UriKind.Relative));
        }

        private void cmdback(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }
    }
}