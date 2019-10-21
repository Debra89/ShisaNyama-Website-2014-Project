using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;
namespace DorisShisaMobileApplication
{
    public partial class ContactUs : PhoneApplicationPage
    { /*! 
    Allow the visitors to contact the store
       */
        public ContactUs()
        {
            InitializeComponent();
            txtname.Text = "";
            txtemail.Text = "";
            txtsubject.Text = "";
            txtmessage.Text = "";
        }

        private void cmdCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private void cmdSubmit_Click(object sender, RoutedEventArgs e)
        { if (txtname.Text == "") { MessageBox.Show("Please enter your name"); }
            if (txtemail.Text == "") { MessageBox.Show("Please enter your email"); }
            if (txtsubject.Text == "") { MessageBox.Show("Please enter the subject"); }
            if (txtmessage.Text == "") { MessageBox.Show("Please enter the message"); }
            MessageBox.Show("Message sent successfully");
        
        }
    }
}