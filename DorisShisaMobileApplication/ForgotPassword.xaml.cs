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
    public partial class ForgotPassword : PhoneApplicationPage
    { /*! 
    Allow the customer to recover their forgotten passwords
       */
        public ForgotPassword()
        {
            InitializeComponent();
            txtemail.Text = "";
            txtcontact.Text = "";
        }
        WebUsers WebUsers = new WebUsers();
        private void cmdsubmit_Click(object sender, RoutedEventArgs e)
        {
           

            WebUsers.Email = txtemail.Text;

            if (txtemail.Text == "") { MessageBox.Show("Please enter your email"); }
            WebUsers.Password = "Shisa";
            Service1Client msg = new Service1Client();

            msg.ForgotPasswordCompleted += new EventHandler<ServiceReference1.ForgotPasswordCompletedEventArgs>(msg_ForgotPasswordCompleted);
            msg.ForgotPasswordAsync(WebUsers);

        }

        void msg_ForgotPasswordCompleted(object sender, ServiceReference1.ForgotPasswordCompletedEventArgs e)
        {


            if (e.Result == "")
            {
                MessageBox.Show("Password not sent Successfully!.");

            }
            else
            {
                MessageBox.Show("Password sent Successfully! to ." + WebUsers.Email);

            }

            txtemail.Text = "";
            txtcontact.Text = "";
       

        

        }

       

        
        }
        }
    
