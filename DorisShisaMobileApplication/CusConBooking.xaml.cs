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
    public partial class CusConBooking : PhoneApplicationPage
    { /*! 
    Allow the customer to confirm their booking
       */
        public CusConBooking()
        {
            InitializeComponent();
        }

        BookingDetails Booking = new BookingDetails();
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            this.txtemail.Text = NavigationContext.QueryString["Email"];
            this.txtname.Text = NavigationContext.QueryString["Name"];
            this.txtcontact.Text = NavigationContext.QueryString["Cell"];
            this.txtnumber.Text = NavigationContext.QueryString["NumberOfPeople"];
            this.txtdate.Text = NavigationContext.QueryString["Dates"];
            this.txttime.Text = NavigationContext.QueryString["Times"];
        }
        private void cmdCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/HomePage.xaml", UriKind.Relative));
        }

        private void cmdSubmit_Click(object sender, RoutedEventArgs e)
        {
            Booking.Email = txtemail.Text;
            Booking.Name = txtname.Text;

            Booking.Name = txtname.Text;

            Booking.Cell = txtcontact.Text;
            Booking.NumberOfPeople = txtnumber.Text;
            Booking.Dates = Convert.ToDateTime(txtdate.Text);
            Booking.Times = DateTime.Parse(txttime.Text);
            Booking.Request = "Please Reserve for me table 5.";
            Service1Client client = new Service1Client();

            client.bookuserCompleted += new EventHandler<ServiceReference1.bookuserCompletedEventArgs>(client_bookuserCompleted);
            client.bookuserAsync(Booking);
        }

        void client_bookuserCompleted(object sender, ServiceReference1.bookuserCompletedEventArgs e)
        {
            if (e.Result == "")
            {
                MessageBox.Show(Booking.Name + " Your booking failed.");
            }
            else
            {
                MessageBox.Show(Booking.Name + " Your booking was Successfully.");
            }
            txtcontact.Text = "";
            txtemail.Text = "";
            txtname.Text = "";
            txtdate.Text = "";
            txttime.Text = "";
            txtnumber.Text = "";

        }
    }
}