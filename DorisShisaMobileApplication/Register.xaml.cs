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
    public partial class Register : PhoneApplicationPage
    { /*! 
    Allow the visitor to register to use the mobile Application
       */
        public Register()
        {
            InitializeComponent();
        }
        WebUsers WebUsers = new WebUsers();
        private void cmdRegister_Click(object sender, RoutedEventArgs e)
        {
            WebUsers.Surname = txtsurname.Text;
            if (txtsurname.Text == "") { MessageBox.Show("Please enter your Surname"); }
            WebUsers.Name = txtname.Text;
            if (txtname.Text == "") { MessageBox.Show("Please enter your Name"); }
            WebUsers.Cell = txtcell.Text;
            if (txtcell.Text == "") { MessageBox.Show("Please enter your Phone number"); }
            WebUsers.Email = txtemail.Text;
            if (txtemail.Text == "") { MessageBox.Show("Please enter your Email Adress"); }
            WebUsers.UserLevel = "3";
            WebUsers.Password = txtpassword.Password;
            Service1Client client = new Service1Client();

            client.InsertUserDetailsCompleted += new EventHandler<ServiceReference1.InsertUserDetailsCompletedEventArgs>(client_InsertUserDetailsCompleted);
            client.InsertUserDetailsAsync(WebUsers);
        }

        void client_InsertUserDetailsCompleted(object sender, ServiceReference1.InsertUserDetailsCompletedEventArgs e)
        {
            if (e.Result == "")
            {
                MessageBox.Show(WebUsers.Name +" Your registration failed.");
            }
            else
            {
                MessageBox.Show(WebUsers.Name +" Your registration was Successfully you can now login.");
                NavigationService.Navigate(new Uri("/Login.xaml", UriKind.Relative));
            }
            txtcell.Text = "";
            txtemail.Text = "";
            txtname.Text = "";
            txtsurname.Text = "";


        }

        private void cmdCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }
    }
}