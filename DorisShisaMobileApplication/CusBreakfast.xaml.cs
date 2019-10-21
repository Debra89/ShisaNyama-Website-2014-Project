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
    public partial class CusBreakfast : PhoneApplicationPage
    { /*! 
    Allow the customer to view the breakfast menu
       */
        public CusBreakfast()
        {
            InitializeComponent();
        }
        OrderDetails OrderTable = new OrderDetails();
        void client_InsertOrderDetailsCompleted(object sender, ServiceReference1.InsertOrderDetailsCompletedEventArgs e)
        {
            if (e.Result == "")
            {
                MessageBox.Show("Your order for" + OrderTable.ProductName + "failed.");
            }
            else
            {
                MessageBox.Show("Your order for " + OrderTable.ProductName + " was Successfully.");
            }

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OrderTable.CustomerEmail = SessionManager.Session["Email"].ToString();
            OrderTable.ProductName = "Micro breakfast";

            OrderTable.ProductPrice = ("40");
            OrderTable.ProductID = ("1");

            Service1Client client = new Service1Client();

            client.InsertOrderDetailsCompleted += new EventHandler<ServiceReference1.InsertOrderDetailsCompletedEventArgs>(client_InsertOrderDetailsCompleted);
            client.InsertOrderDetailsAsync(OrderTable);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OrderTable.CustomerEmail = SessionManager.Session["Email"].ToString();
            OrderTable.ProductName = "Farmstyle breakfast";

            OrderTable.ProductPrice = ("65");
            OrderTable.ProductID = ("2");

            Service1Client client = new Service1Client();

            client.InsertOrderDetailsCompleted += new EventHandler<ServiceReference1.InsertOrderDetailsCompletedEventArgs>(client_InsertOrderDetailsCompleted);
            client.InsertOrderDetailsAsync(OrderTable);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            OrderTable.CustomerEmail = SessionManager.Session["Email"].ToString();
            OrderTable.ProductName = "Southern style breakfast";

            OrderTable.ProductPrice = ("60");
            OrderTable.ProductID = ("3");

            Service1Client client = new Service1Client();

            client.InsertOrderDetailsCompleted += new EventHandler<ServiceReference1.InsertOrderDetailsCompletedEventArgs>(client_InsertOrderDetailsCompleted);
            client.InsertOrderDetailsAsync(OrderTable);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            OrderTable.CustomerEmail = SessionManager.Session["Email"].ToString();
            OrderTable.ProductName = "Egg Benedict";

            OrderTable.ProductPrice = ("60");
            OrderTable.ProductID = ("4");

            Service1Client client = new Service1Client();

            client.InsertOrderDetailsCompleted += new EventHandler<ServiceReference1.InsertOrderDetailsCompletedEventArgs>(client_InsertOrderDetailsCompleted);
            client.InsertOrderDetailsAsync(OrderTable);
        }

        private void cmdback(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CusMenu.xaml", UriKind.Relative));
        }
    }
}