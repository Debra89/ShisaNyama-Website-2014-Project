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
    public partial class CusMenu : PhoneApplicationPage
    { /*! 
    Allow the customer to view the menu
       */
        public CusMenu()
        {
            InitializeComponent();
        }

        private void cmdbreakfast(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CusBreakfast.xaml", UriKind.Relative));
        }

        private void cmddesserts(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CusDesserts.xaml", UriKind.Relative));
        }

        private void cmdsandwiches(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CusSandwiches.xaml", UriKind.Relative));
        }

        private void cmdback(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Homepage.xaml", UriKind.Relative));
        }

       

        private void cmdorder_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Vieworder.xaml", UriKind.Relative));
        }
    }
}