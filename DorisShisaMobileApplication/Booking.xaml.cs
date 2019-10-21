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
    public partial class Booking : PhoneApplicationPage
    { /*! 
    Allow users to make a boooking
       */
        public Booking()
        {
            InitializeComponent();
        }


        private void cmdCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
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
                    NavigationService.Navigate(new Uri("/ConBooking.xaml?Email= " + this.txtemail.Text + "&Name=" + this.txtname.Text + "&Cell=" + this.txtcontact.Text + "&NumberOfPeople=" + this.txtnumber.Text + "&Dates=" + Convert.ToDateTime(myStr) + "&Times=" + Convert.ToDateTime(mystrs), UriKind.Relative));


                }
            }
        }
