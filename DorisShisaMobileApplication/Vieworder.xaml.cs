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
    public partial class Vieworder : PhoneApplicationPage
    { /*! 
    Allow the customer to view their previous orders
       */
        public Vieworder()
        {
            InitializeComponent();
            OrderDetails Order = new OrderDetails();
            Service1Client msg = new Service1Client();
            msg.GetProductNameCompleted += (g, val) =>
          {
             
              foreach (ServiceReference1.OrderDetails i in val.Result)
              {
              
                      string objct;

                   

                   objct = Convert.ToString( i.ProductName) + Environment.NewLine ;
                  
                  listproducts.Items.Add(objct);
                    
              }
             
          };
            msg.GetProductNameAsync(SessionManager.Session["Email"].ToString());
        }

        private void listproducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            OrderDetails Orders = new OrderDetails();
            Service1Client msgs = new Service1Client();
            string id = listproducts.SelectedItem.ToString().Split(',').First();
            Orders.ProductName = listproducts.SelectedItem.ToString();
            msgs.DeleteOrderCompleted += new EventHandler<ServiceReference1.DeleteOrderCompletedEventArgs>(client_DeleteOrderCompleted);
            msgs.DeleteOrderAsync(Orders);

        }

        void client_DeleteOrderCompleted(object sender, ServiceReference1.DeleteOrderCompletedEventArgs e)
        {
            if (e.Result == false)
            {
                MessageBox.Show(" Your product can't be deleted.");
            }
            else
            {
                MessageBox.Show("product deleted successfuly.");
                
            }
           

        }

       
        private void cmdback_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/HomePage.xaml", UriKind.Relative));
        }
  

       

  }

           
       
  }

        
    
