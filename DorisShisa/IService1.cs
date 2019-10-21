using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
namespace DorisShisa
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        /*! 
     Insert user details in the database database after webuser registration
       */
        [OperationContract]
        string InsertUserDetails(WebUsers WebUsers);
        /*! 
         Log webusers to the application system and allow them to assess the application system according to their userlevel
         */
        [OperationContract]
        string logUsers(WebUsers WebUsers);
        /*! 
       Insert subscription details into the database after webuser insert their subscription details
       */
        [OperationContract]
        string InsertSubscriptions(SubscriptionDetails Subscribers);
        /*! 
       Allow registered users to recover their forgotten passwords
       */
        [OperationContract]
        string ForgotPassword(WebUsers WebUsers);
        /*! 
     allow registered users to chnage their passwords
      */
        [OperationContract]
        string ChangePassword(WebUsers WebUsers);
        /*! 
     Select registered webusers information to be displayed on the application system
      */
        [OperationContract]
        WebUsers Select(WebUsers WebUsers);
        /*! 
     Update registered users details in the database
        */
        [OperationContract]
        string UpdateUserRegDetails(WebUsers WebUsers);
        /*! 
       Get all webusers details from the database to display to the admin
       */
        [OperationContract]
        DataSet GetUserRegDetails();
        /*! 
      Fetch webusers details, for the webuser to update
       */
        [OperationContract]
        DataSet FetchUpdatedRecords(WebUsers WebUsers);
        /*! 
        Delete webusers details from the database
         */
        [OperationContract]
        bool DeleteUserRegDetails(WebUsers WebUsers);




        /*! 
      Doris Shisanyama business functions
       */
        /*! 
       Insert booking details to the database after webuser insert their booking details
        */
        [OperationContract]
        string bookuser(BookingDetails Bookings);
        /*! 
      Insert order details in the database after webuser order
      */
        [OperationContract]
        string InsertOrderDetails(OrderDetails OrderTable);
        /*! 
   Get Webusers details to display to each customer after logging in
     */
        [OperationContract]
        WebUsers GetCusEmail(string Email);
        /*! 
    Get order details from the order table to display to each customer order details
      */
        [OperationContract]
        OrderDetails GetuserOrderDetails(string Email);
        /*! 
    Delete order details from the database
     */
        [OperationContract]
        bool DeleteOrder(OrderDetails products);
        /*! 
    Get order details from the database, for the customer to view their order details
      */
        [OperationContract]
        DataSet Vieworder(OrderDetails OrderTable);
        /*! 
       Insert new products details in the database
       */
        [OperationContract]
        string AddProducts(ProductsDetails Products);
        /*! 
      Get products details to display from the the database to the admin
       */

        [OperationContract]
        DataSet GetProducts();
        /*! 
     Delete product details from the database
      */
        [OperationContract]
        bool DeleteRoducts(ProductsDetails products);
        /*! 
      Get product details to update
       */
        [OperationContract]
        DataSet FetchUpdatedProducts(ProductsDetails products);
        /*! 
     Update product details
      */
        [OperationContract]
        string UpdateProducts(ProductsDetails products);
        /*! 
        Insert Booking task in the database
        */

        [OperationContract]
        string Insertbookingtask(TaskDetails Task);
        /*! 
       Insert order task details in the database
       */
        [OperationContract]
        string InsertOrdertask(TaskDetails Task);
        /*! 
       Insert Assigned task to the booking details, after task has been assigned
       */
        [OperationContract]
        string InsertAssigned(BookingDetails Bookings);
        /*! 
       Insert Assigned in the order details, after order has been assigned
       */
        [OperationContract]
        string InsertTaskAssigned(OrderDetails OrderTable);
        /*! 
      Get booking details from the database to display to the admin
       */
        [OperationContract]
        DataSet GetBookingDetails(BookingDetails Bookings);
        /*! 
      Get order details from the database to display to the admin
       */
        [OperationContract]
        DataSet GetOrderDetails(OrderDetails OrderTable);
        /*! 
      Get booking task details from the database to display for the admin
       */
        [OperationContract]
        DataSet GetBookingTAskDetails(TaskDetails BookingTask);
        /*! 
        Get order task details from the database to display to the admin
        */
        [OperationContract]
        DataSet GetOrderTaskDetails(TaskDetails OrderTask);
        /*! 
       Delete booking task details from the booking task table in the database
        */
        [OperationContract]
        bool DeleteBookingTAskDetails(TaskDetails BookingTask);
        /*! 
    Delete order task details from the order task table in the database
     */
        [OperationContract]
        bool DeleteOrderTaskDetails(TaskDetails OrderTask);
        /*! 
  Update booking task details from the booking task table in the database
     */
        [OperationContract]
        string UpdateBookingTAskDetails(TaskDetails BookingTask);
        /*! 
     Update order task details from the order task table in the database
      */
        [OperationContract]
        string UpdateOrderTaskDetails(TaskDetails OrderTask);

        /*! 
   Get order details to display on the mobile
     */
        [OperationContract]
        List<OrderDetails> GetProductName(string Email);

        [OperationContract]
        OrderDetails GetUserOrderProductDetails(string ProductName);
      




        /*! 
     Reports
       */
        /*! 
     Insert page visits  in the database from page visits visitors
       */
        [OperationContract]
        string InsertPageVisit(PageVisit PageVisitTable);
        /*! 
     Insert activity logs in the database from customer activity logs in Applications
       */
        [OperationContract]
        string InsertActivityLogs(ActivityLogs ActivityTable);
        /*! 
 Insert subscription report in the database 
   */
        [OperationContract]
        string SubscriptionsReport(ReportDetails Report);
        /*! 
       Insert Booking report in the database
         */
        [OperationContract]
        string BookingReport(ReportDetails Report);

        /*! 
Insert Order numbers in the database 
  */
        [OperationContract]
        string OrderReport(ReportDetails Report);
       
        
    }

   
}
