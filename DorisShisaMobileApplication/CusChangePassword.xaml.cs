using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using DorisShisaMobileApplication.ServiceReference1;
namespace DorisShisaMobileApplication
{
    public partial class cus : PhoneApplicationPage
    { /*! 
     Allow the customer to change their password
       */
        public cus()
        {
            InitializeComponent();
            ShowInfo();
        }
        WebUsers user = new WebUsers();
        void ShowInfo()
        {
           

            Service1Client client = new Service1Client();
            client.GetCusEmailCompleted += new EventHandler<ServiceReference1.GetCusEmailCompletedEventArgs>(client_GetCusEmailCompleted);
            client.GetCusEmailAsync(SessionManager.Session["Email"].ToString());


        }

        void client_GetCusEmailCompleted(object sender, ServiceReference1.GetCusEmailCompletedEventArgs e)
        {

            if (e.Result != null)
            {

                WebUsers webusers = e.Result;



                ContentPanel.DataContext = webusers;

            }

        }

        private void cmdCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/HomePage.xaml", UriKind.Relative));
        }

        private void cmdSubmit_Click(object sender, RoutedEventArgs e)
        {
            user.Password = txtpassword.Password;
            if (txtpassword.Password == "") { MessageBox.Show("Please enter your new password"); }
            user.Email = SessionManager.Session["Email"].ToString();
            Service1Client client = new Service1Client();

            client.ChangePasswordCompleted += new EventHandler<ServiceReference1.ChangePasswordCompletedEventArgs>(client_ChangePasswordCompleted);
            client.ChangePasswordAsync(user);
        }

        void client_ChangePasswordCompleted(object sender, ServiceReference1.ChangePasswordCompletedEventArgs e)
        {
            if (e.Result == "")
            {
                MessageBox.Show(user.Name + " Your password was changed failed.");
            }
            else
            {
                MessageBox.Show(user.Name + " Your password was changed Successfully.");

            }
            txtpassword.Password = "";
            txtemail.Text = "";
        }
    }
}