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
    public partial class Login : PhoneApplicationPage
    { /*! 
    Allow registered users to login
       */
        public Login()
        {
            InitializeComponent();
        }

        private void cmdLogin_Click(object sender, RoutedEventArgs e)
        {
            WebUsers WebUsers = new WebUsers();
            SessionManager.Session["Email"] = txtUsername.Text;
            WebUsers.Email = txtUsername.Text;
            if (txtUsername.Text == "") { MessageBox.Show("Please enter your Email"); }
            WebUsers.Password = Password.Password;
            if (Password.Password == "") { MessageBox.Show("Please enter your Password"); }
            Service1Client msg = new Service1Client();

            msg.logUsersCompleted += new EventHandler<ServiceReference1.logUsersCompletedEventArgs>(msg_logUsersCompleted);
            msg.logUsersAsync(WebUsers);

        }

        void msg_logUsersCompleted(object sender, ServiceReference1.logUsersCompletedEventArgs e)
        {


            if (e.Result == "Customers")
            {
                MessageBox.Show("Hi " + SessionManager.Session["Email"].ToString() + ", you have successfully logged in!");
                //This will redirect to the next page for valid user. The value of str will be sent in the constructor of nextpage because if user needs to display Welcome username then that message can be displayed with the help of str value.
                NavigationService.Navigate(new Uri("/HomePage.xaml", UriKind.Relative));
            }


            else if (e.Result == "Staff")
            {
                MessageBox.Show("You can't use the Mobile for now!.");

            }
            else if (e.Result == "UserDoesntExist")
            {


                MessageBox.Show("Username or password incorrect.");
            }

           
            Password.Password = "";
       
        }

        private void cmdRegister(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Register.xaml", UriKind.Relative));

        }

        private void cmdforgotpassword(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ForgotPassword.xaml", UriKind.Relative));

        }

        private void cmdback(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));

        }

        
        
    }
}