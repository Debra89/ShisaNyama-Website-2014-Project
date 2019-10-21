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
    public partial class CusUpdateDetails : PhoneApplicationPage
    { /*! 
    Allow the customer to update their details
       */
        
        public CusUpdateDetails()
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
           
            user.Surname = txtsurname.Text;

            user.Name = txtname.Text;

            user.Cell = txtcell.Text;

            user.Email = SessionManager.Session["Email"].ToString();
            Service1Client client = new Service1Client();

            client.UpdateUserRegDetailsCompleted += new EventHandler<ServiceReference1.UpdateUserRegDetailsCompletedEventArgs>(client_UpdateUserRegDetailsCompleted);
            client.UpdateUserRegDetailsAsync(user);
        }

        void client_UpdateUserRegDetailsCompleted(object sender, ServiceReference1.UpdateUserRegDetailsCompletedEventArgs e)
        {
            if (e.Result == "")
            {
                MessageBox.Show(user.Name + " Your details failed to update.");
            }
            else
            {
                MessageBox.Show(user.Name + " Your details updated Successfully.");
               
            }
            txtcell.Text = "";
            txtemail.Text = "";
            txtname.Text = "";
            txtsurname.Text = "";
        }
    }
}