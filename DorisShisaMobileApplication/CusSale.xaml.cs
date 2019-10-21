using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.ServiceModel;
using DorisShisaMobileApplication.ServiceReference1;
namespace DorisShisaMobileApplication
{
    public partial class CusSale : PhoneApplicationPage
    { /*! 
    Allow the customer to view the store sale
       */
        public CusSale()
        {
            InitializeComponent();
        }
        OrderDetails OrderTable = new OrderDetails();
        private void cmdOrder1_Click_1(object sender, RoutedEventArgs e)
        {
           
            OrderTable.CustomerEmail = SessionManager.Session["Email"].ToString();
            OrderTable.ProductName = "Micro breakfast";
           
            OrderTable.ProductPrice =("40");
            OrderTable.ProductID = ("1");

            Service1Client client = new Service1Client();

            client.InsertOrderDetailsCompleted += new EventHandler<ServiceReference1.InsertOrderDetailsCompletedEventArgs>(client_InsertOrderDetailsCompleted);
            client.InsertOrderDetailsAsync(OrderTable);
        }

        void client_InsertOrderDetailsCompleted(object sender, ServiceReference1.InsertOrderDetailsCompletedEventArgs e)
        {
            if (e.Result == "")
            {
                MessageBox.Show("Your order for" + OrderTable.ProductName +"failed.");
            }
            else
            {
                MessageBox.Show("Your order for " + OrderTable.ProductName +" was Successfully.");
            }
            
        }

        private void cmdorder2_Click_2(object sender, RoutedEventArgs e)
        {
            OrderDetails OrderTable = new OrderDetails();
            OrderTable.CustomerEmail = SessionManager.Session["Email"].ToString();
            OrderTable.ProductName = "Farmstyle breakfast";
            OrderTable.ProductPrice = "65";
            OrderTable.ProductID = "2";

            Service1Client client = new Service1Client();

            client.InsertOrderDetailsCompleted += new EventHandler<ServiceReference1.InsertOrderDetailsCompletedEventArgs>(client_InsertOrderDetailsCompleted);
            client.InsertOrderDetailsAsync(OrderTable);
        }

        private void cmdorder3_Click_3(object sender, RoutedEventArgs e)
        {
            
            OrderTable.CustomerEmail = SessionManager.Session["Email"].ToString();
            OrderTable.ProductName = "Cape Velvet Creme";
            OrderTable.ProductPrice = ("65");
            OrderTable.ProductID = "3";

            Service1Client client = new Service1Client();

            client.InsertOrderDetailsCompleted += new EventHandler<ServiceReference1.InsertOrderDetailsCompletedEventArgs>(client_InsertOrderDetailsCompleted);
            client.InsertOrderDetailsAsync(OrderTable);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
           
            OrderTable.CustomerEmail = SessionManager.Session["Email"].ToString();
            OrderTable.ProductName = "Vanilla Panacotta";
            OrderTable.ProductPrice = ("55");
            OrderTable.ProductID = "4";

            Service1Client client = new Service1Client();

            client.InsertOrderDetailsCompleted += new EventHandler<ServiceReference1.InsertOrderDetailsCompletedEventArgs>(client_InsertOrderDetailsCompleted);
            client.InsertOrderDetailsAsync(OrderTable);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
           NavigationService.Navigate(new Uri("/HomePage.xaml", UriKind.Relative));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Vieworder.xaml", UriKind.Relative));
        }
    }
}