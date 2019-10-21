using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Data;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using DorisShisaMobileApplication.ServiceReference1;
namespace DorisShisaMobileApplication
{
    public partial class CusBooking : PhoneApplicationPage
    {
        /*! 
    Allow the customer to make a booking
       */
        public CusBooking()
        {
            InitializeComponent();
          
             ShowInfo();
        }

       
        void ShowInfo()
        {
            WebUsers user = new WebUsers();
            
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
            if (txtcontact.Text == "") { MessageBox.Show("Please enter your contact number"); }
            if (txtname.Text == "") { MessageBox.Show("Please enter your Name"); }
            if (txtnumber.Text == "") { MessageBox.Show("Please enter number of people"); }
            if (txtemail.Text == "") { MessageBox.Show("Please enter your Email Adress"); }
            string myStr = this.txtdate.Value.ToString();
            DateTime myDate = DateTime.Parse(myStr);
            string mystrs = this.txttime.Value.ToString();
            DateTime mytime = DateTime.Parse(mystrs);
            MessageBox.Show("Please confirm your booking!.");
            NavigationService.Navigate(new Uri("/CusConBooking.xaml?Email= " + this.txtemail.Text + "&Name=" + this.txtname.Text + "&Cell=" + this.txtcontact.Text + "&NumberOfPeople=" + this.txtnumber.Text + "&Dates=" + Convert.ToDateTime(myStr) + "&Times=" + Convert.ToDateTime(mystrs), UriKind.Relative));
            

 

        }
    }
}