using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using DorisShisaMobileApplication.ServiceReference1;
namespace DorisShisaMobileApplication
{
    public partial class MainPage : PhoneApplicationPage
    { /*! 
   this is the home page the first page that the visitor get into contact with.
       */
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            txtemail.Text = "";
        }

        private void lblRegister_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Register.xaml", UriKind.Relative));
        }

        private void lblSignIn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Login.xaml", UriKind.Relative));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SubscriptionDetails users = new SubscriptionDetails();
            users.Email = txtemail.Text;
            if (txtemail.Text == "") { MessageBox.Show("Please enter your email"); }
            Service1Client msg = new Service1Client();

            msg.InsertSubscriptionsCompleted += new EventHandler<ServiceReference1.InsertSubscriptionsCompletedEventArgs>(msg_InsertSubscriptionsCompleted);
            msg.InsertSubscriptionsAsync(users);

        }

        void msg_InsertSubscriptionsCompleted(object sender, ServiceReference1.InsertSubscriptionsCompletedEventArgs e)
        {


            if (e.Result == "")
            {
                MessageBox.Show("Your Subscription failed.");
            }
            else
            {
                MessageBox.Show("Your Subscription was Successfully.");
            }
            txtemail.Text = "";
          
       
        }
    }
}