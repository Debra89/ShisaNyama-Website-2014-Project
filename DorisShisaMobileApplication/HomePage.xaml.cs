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
    public partial class HomePage : PhoneApplicationPage
    { /*! 
   Registered users get to this page after logging in
       */
        public HomePage()
        {
            InitializeComponent();
            lblSession.Text = SessionManager.Session["Email"].ToString();
        }

        private void lblsignout_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

       
        private void cmdupdatedetails_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CusUpdateDetails.xaml", UriKind.Relative));
        }

        private void cmdchangepassword_Click(object sender, RoutedEventArgs e)
        {
              NavigationService.Navigate(new Uri("/CusChangePassword.xaml", UriKind.Relative));
        }
        
    }
}