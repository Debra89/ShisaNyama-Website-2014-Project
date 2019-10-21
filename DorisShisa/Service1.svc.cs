using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Web;

namespace DorisShisa
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|DorisShisa.mdf;Integrated Security=True");
        /*! 
          Insert user details in the database database after webuser registration
          */
        public string InsertUserDetails(WebUsers WebUsers)
        {
            

            string Message;
            con.Open();

            DateTime date = DateTime.Parse(DateTimeOffset.Now.ToString());

            SqlCommand command = new SqlCommand("INSERT INTO [WebUsers] ([Email],[Name],[Surname] ,[Cell],[Password],[UserLevel],[RegDate])Values ('" + WebUsers.Email + "', '" + WebUsers.Name + "', '" + WebUsers.Surname + "', '" + WebUsers.Cell + "', '" + WebUsers.Password + "', '" + WebUsers.UserLevel + "','" + date + "')", con);

            int result = command.ExecuteNonQuery();

            if (result == 1)
            {

                Message = WebUsers.Name + " " + WebUsers.Surname + " Details Registered successfully";

            }

            else
            {

                Message = WebUsers.Name + " " + WebUsers.Surname + " Details not Registered successfully";

            }

            con.Close();

            return Message;



        }

        /*! 
         Log webusers to the application system and allow them to assess the application system according to their userlevel
         */
        public string logUsers(WebUsers WebUsers)
        {
            string msg;

            System.Threading.Thread.Sleep(2000);
            con.Open();
            string comString;

            comString = "SELECT * FROM [WebUsers] WHERE  Email=@Email";
            SqlCommand com = new SqlCommand(comString, con);
            com.Parameters.AddWithValue("@Email", WebUsers.Email);

            SqlDataReader reader = com.ExecuteReader();

            reader.Read();

            if (reader.HasRows == true)
            {

                WebUsers.Email = reader["Email"].ToString();


                WebUsers.UserLevel = reader["UserLevel"].ToString();


                if ((reader["Password"].ToString() == (WebUsers.Password)) && (reader["Email"].ToString() == WebUsers.Email))
                {
                    msg = "UserExists";
                    if ((reader["UserLevel"].ToString() == "1") || (reader["UserLevel"].ToString() == "2"))
                    {
                        msg = "Staff";
                    }
                    else
                    {
                        msg = "Customers";
                    }

                }
                else
                {
                    msg = "UserDoesntExist"; //"Incorrect username or password";
                    //msg += "/n Have you registered?";
                }
            }
            else
            {
                msg = "UserDoesntExist";
            }
            con.Close();
            return msg;
        }

        /*! 
         Insert subscription details into the database after webuser insert their subscription details
         */
        public string InsertSubscriptions(SubscriptionDetails Subscribers)
        {
            string userid = UserID();
            string Message;
            con.Open();
            int userID = Convert.ToInt32(userid);
            userID += 1;
            DateTime date = DateTime.Parse(DateTimeOffset.Now.ToString());

            SqlCommand command = new SqlCommand("INSERT INTO [Subscription] ([UserID], [Email],[SubDate]) Values ('" + userID + "', '" + Subscribers.Email + "','" + date + "')", con);

            int result = command.ExecuteNonQuery();

            if (result == 1)
            {

                Message = Subscribers.Email + " Is subscribed successfully";

            }

            else
            {

                Message = Subscribers.Email + "Details not Registered successfully";

            }

            con.Close();
            UpdateUserID(userID);
            return Message;
        }
        /*! 
         Insert user id automatical in the database, when a user register
         */
        private string UserID()
        {
            SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|DorisShisa.mdf;Integrated Security=True");


            SqlCommand cmd = new SqlCommand("Select UserID from UserIDControl", Con);
            Con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return reader["UserID"].ToString();
            }
            else
            {
                return "Bad Registration";
            }

        }
        /*! 
       Update automatic user id for the next customer registration 
        */
        private void UpdateUserID(int UpdatedNumber)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|DorisShisa.mdf;Integrated Security=True");

            SqlCommand cmd = new SqlCommand
                ("Update UserIDControl Set UserID=" + UpdatedNumber, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            conn.Close();

        }

        /*! 
        Allow registered users to recover their forgotten passwords
        */
        public string ForgotPassword(WebUsers WebUsers)
        {
            string Message;

            if (con.State == ConnectionState.Closed)
            {

                con.Open();

            }

            SqlCommand cmd = new SqlCommand("update WebUsers set Password=@Password where Email=@Email", con);


            cmd.Parameters.AddWithValue("@Email", WebUsers.Email);
            cmd.Parameters.AddWithValue("@Password", WebUsers.Password);

            int result = cmd.ExecuteNonQuery();

            if (result == 1)
            {

                Message = "Password  changed successfully";

            }

            else
            {

                Message = "Password could not be Changed";

            }

            con.Close();

            return Message;

        }

        /*! 
       allow registered users to chnage their passwords
        */
        public string ChangePassword(WebUsers WebUsers)
        {
            string Message;

            if (con.State == ConnectionState.Closed)
            {

                con.Open();

            }

            SqlCommand cmd = new SqlCommand("update WebUsers set Password=@Password where Email=@Email", con);


            cmd.Parameters.AddWithValue("@Email", WebUsers.Email);
            cmd.Parameters.AddWithValue("@Password", WebUsers.Password);

            int result = cmd.ExecuteNonQuery();

            if (result == 1)
            {

                Message = "Password  changed successfully";

            }

            else
            {

                Message = "Password could not be Changed";

            }

            con.Close();

            return Message;
        }

        /*! 
       Select registered webusers information to be displayed on the application system
        */
        public WebUsers Select(WebUsers WebUsers)
        {
            if (con.State == ConnectionState.Closed)
            {

                con.Open();

            }

            SqlCommand cmd = new SqlCommand("select * from WebUsers where Email=@Email", con);

            cmd.Parameters.AddWithValue("@Email", WebUsers.Email);
            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();

            if (reader.HasRows == true)
            {
                WebUsers.Email = reader["Email"].ToString();
                WebUsers.Cell = reader["Cell"].ToString();
                WebUsers.Name = reader["Name"].ToString();
                WebUsers.Surname = reader["Surname"].ToString();

            }
            con.Close();
            return WebUsers;
        }

        /*! 
     Update registered users details in the database
        */
        public string UpdateUserRegDetails(WebUsers WebUsers)
        {
            string Message;

            if (con.State == ConnectionState.Closed)
            {

                con.Open();

            }

            SqlCommand cmd = new SqlCommand("update WebUsers set Name=@Name,Surname=@Surname,Cell=@Cell where Email=@Email", con);


            cmd.Parameters.AddWithValue("@Email", WebUsers.Email);
            cmd.Parameters.AddWithValue("@Name", WebUsers.Name);
            cmd.Parameters.AddWithValue("@Surname", WebUsers.Surname);
            cmd.Parameters.AddWithValue("@Cell", WebUsers.Cell);

            int result = cmd.ExecuteNonQuery();

            if (result == 1)
            {

                Message = "Record updated successfully";

            }

            else
            {

                Message = "Record could not be updated";

            }

            con.Close();

            return Message;

        }
        /*! 
        Get all webusers details from the database to display to the admin
        */
        public DataSet GetUserRegDetails()
        {

            if (con.State == ConnectionState.Closed)
            {

                con.Open();

            }

            SqlCommand cmd = new SqlCommand("Select * from Webusers", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds);

            cmd.ExecuteNonQuery();

            con.Close();

            return ds;

        }
        /*! 
       Fetch webusers details, for the webuser to update
        */
        public DataSet FetchUpdatedRecords(WebUsers WebUsers)
        {

            if (con.State == ConnectionState.Closed)
            {

                con.Open();

            }

            SqlCommand cmd = new SqlCommand("select * from Webusers where Email=@Email", con);




            cmd.Parameters.AddWithValue("@Email", WebUsers.Email);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds);

            cmd.ExecuteNonQuery();

            con.Close();

            return ds;

        }
        /*! 
       Delete webusers details from the database
        */
       
        public bool DeleteUserRegDetails(WebUsers WebUsers)
        {

            if (con.State == ConnectionState.Closed)
            {

                con.Open();

            }

            SqlCommand cmd = new SqlCommand("delete from Webusers where Email=@Email", con);




            cmd.Parameters.AddWithValue("@Email", WebUsers.Email);

            cmd.ExecuteNonQuery();

            con.Close();

            return true;

        }
        /*! 
       Insert booking details to the database after webuser insert their booking details
        */
        public string bookuser(BookingDetails Bookings)
        {
            string bookingid = BookingID();
            string Message;
            con.Open();
            int bookingID = Convert.ToInt32(bookingid);
            bookingID += 1;

            DateTime date = DateTime.Parse(DateTimeOffset.Now.ToString());

            SqlCommand cmd = new SqlCommand("INSERT INTO [Bookings] ([Name],[Email], [Cell],[NumberOfPeople] , [Dates], [Times], [Request], [BookingID],[BookingDate],[Assigned]) Values ('" + Bookings.Name + "', '" + Bookings.Email + "', '" + Bookings.Cell + "', '" + Bookings.NumberOfPeople + "', '" + "11/9/2013" + "', '" + "13:00" + "', '" + Bookings.Request + "','" + bookingID + "','" + date + "', '" + "NO" + "')", con);



            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {

                Message = Bookings.Name + " your booking is successfully and will be emailed to you soon";

            }

            else
            {

                Message = Bookings.Name + " Bookings not inserted successfully";

            }

            con.Close();
            UpdateBookingID(bookingID);
            return Message;



        }
        /*! 
        Insert booking id automatical to the database after every booking
        */
        private string BookingID()
        {
            SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|DorisShisa.mdf;Integrated Security=True");


            SqlCommand cmd = new SqlCommand("Select BookingID from BookingIDControl", Con);
            Con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return reader["BookingID"].ToString();
            }
            else
            {
                return "Bad Booking";
            }

        }
        /*! 
        Update booking id automatical after each booking
        */
        private void UpdateBookingID(int UpdatedNumber)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|DorisShisa.mdf;Integrated Security=True");

            SqlCommand cmd = new SqlCommand
                ("Update BookingIDControl Set BookingID=" + UpdatedNumber, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            conn.Close();
        }

        /*! 
        Insert order details in the database after webuser order
        */
        public string InsertOrderDetails(OrderDetails OrderTable)
        {
             string orderid = OrderID();
            string Message;
            con.Open();
            int orderID = Convert.ToInt32(orderid);
            orderID += 1;
            DateTime date = DateTime.Parse(DateTimeOffset.Now.ToString());
          

            SqlCommand cmd = new SqlCommand("INSERT INTO [OrderTable]([OrderID],[ProductID],[ProductName],[ProductPrice],[Email],[OrderDate],[Assigned]) values('" + orderID + "', '" + OrderTable.ProductID + "','" + OrderTable.ProductName + "','"+ OrderTable.ProductPrice + "', '" + OrderTable.CustomerEmail + "','" + date + "', '" + "NO" + "')", con);

            
            int result = cmd.ExecuteNonQuery();

            if (result == 1)
            {

                Message = "Order Details Registered successfully";

            }

            else
            {

                Message = "Details not Registered successfully";

            }

            con.Close();
            UpdateOrderTableControl(orderID);
            return Message;
        }
        /*! 
        Insert order id automatical in the database in each order
        */
        private string OrderID()
        {
            SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|DorisShisa.mdf;Integrated Security=True");

         
            SqlCommand cmd = new SqlCommand("Select OrderID from OrderTableControl", Con);
            Con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return reader["OrderID"].ToString();
            }
            else
            {
                return "Bad Order";
            }

        }
        /*! 
        Update Order id automatical each time an order is placed
        */
        private void UpdateOrderTableControl(int UpdatedNumber)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|DorisShisa.mdf;Integrated Security=True");

            SqlCommand cmd = new SqlCommand
                ("Update OrderTableControl Set OrderID=" + UpdatedNumber, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            conn.Close();
        }
        /*! 
        Insert new products details in the database
        */
        public string AddProducts(ProductsDetails Products)
        {


            string Message;
            con.Open();

            SqlCommand cmd = new SqlCommand("insert into Products(ProductID,Name,Description,Category,Price,ImageUrl) values(@ProductID,@Name,@Description,@Category,@Price,@ImageUrl)", con);

            cmd.Parameters.AddWithValue("@ProductID", Products.ProductID);

            cmd.Parameters.AddWithValue("@Name", Products.Name);

            cmd.Parameters.AddWithValue("@Description", Products.Description);

            cmd.Parameters.AddWithValue("@Category", Products.Category);

            cmd.Parameters.AddWithValue("@Price", Products.Price);

            cmd.Parameters.AddWithValue("@ImageUrl", Products.ImageUrl);
            int result = cmd.ExecuteNonQuery();

            if (result == 1)
            {

                Message = "product Details Registered successfully";

            }

            else
            {

                Message = "Product Details not Registered successfully";

            }

            con.Close();

            return Message;


        }

        /*! 
       Get products details to display from the the database to the admin
        */

        public DataSet GetProducts()
        {
            if (con.State == ConnectionState.Closed)
            {

                con.Open();

            }

            SqlCommand cmd = new SqlCommand("Select * from Products", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds);

            cmd.ExecuteNonQuery();

            con.Close();

            return ds;
        }

        /*! 
       Delete product details from the database
        */
        public bool DeleteRoducts(ProductsDetails Products)
        {
            if (con.State == ConnectionState.Closed)
            {

                con.Open();

            }

            SqlCommand cmd = new SqlCommand("delete from Products where ProductID=@ProductID", con);




            cmd.Parameters.AddWithValue("@ProductID", Products.ProductID);

            cmd.ExecuteNonQuery();

            con.Close();

            return true;
        }

        /*! 
       Get product details to update
        */
        public DataSet FetchUpdatedProducts(ProductsDetails Products)
        {

            if (con.State == ConnectionState.Closed)
            {

                con.Open();

            }

            SqlCommand cmd = new SqlCommand("select * from Products where ProductID=@ProductID", con);




            cmd.Parameters.AddWithValue("@ProductID", Products.ProductID);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds);

            cmd.ExecuteNonQuery();

            con.Close();

            return ds;

        }
        /*! 
       Update product details
        */

        public string UpdateProducts(ProductsDetails Products)
        {
            string Message;

            if (con.State == ConnectionState.Closed)
            {

                con.Open();

            }

            SqlCommand cmd = new SqlCommand("update Products set Name=@Name,Description=@Description,Category=@Category,Price=@Price,ImageUrl=@ImageUrl where ProductID=@ProductID", con);


            cmd.Parameters.AddWithValue("@ProductID", Products.ProductID);

            cmd.Parameters.AddWithValue("@Name", Products.Name);

            cmd.Parameters.AddWithValue("@Description", Products.Description);

            cmd.Parameters.AddWithValue("@Category", Products.Category);

            cmd.Parameters.AddWithValue("@Price", Products.Price);

            cmd.Parameters.AddWithValue("@ImageUrl", Products.ImageUrl);

            int result = cmd.ExecuteNonQuery();

            if (result == 1)
            {

                Message = "Record updated successfully";

            }

            else
            {

                Message = "Record could not be updated";

            }

            con.Close();

            return Message;
        }


        /*! 
        Insert Booking task in the database
        */


        public string Insertbookingtask(TaskDetails Task)
        {
            string taskid = BookingTaskID();
            string Message;
            con.Open();
            int TaskID = Convert.ToInt32(taskid);
            TaskID += 1;
           
          

            SqlCommand cmd = new SqlCommand("INSERT INTO [BookingTask]([EmpName],[BookingID],[TableNo],[TaskID],[Times],[Dates]) values('" + Task.EmpName + "','" + Task.BookingID + "','"+ Task.TableNo + "', '" + TaskID + "','" + Task.Times + "', '" + Task.Dates + "')", con);

            
            int result = cmd.ExecuteNonQuery();

            if (result == 1)
            {

                Message = "Task details Registered successfully";

            }

            else
            {

                Message = "Task details not Registered successfully";

            }

            con.Close();
            UpdateBookingTaskControl(TaskID);
            return Message;
        }
        /*! 
        Insert booking task  id automatical into the database
        */
        private string BookingTaskID()
        {
            SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|DorisShisa.mdf;Integrated Security=True");

         
            SqlCommand cmd = new SqlCommand("Select TaskID from BookingTaskControl", Con);
            Con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return reader["TaskID"].ToString();
            }
            else
            {
                return "Bad Task";
            }

        }
        /*! 
       Update booking task id automatical after each assigned task
        */
        private void UpdateBookingTaskControl(int UpdatedNumber)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|DorisShisa.mdf;Integrated Security=True");

            SqlCommand cmd = new SqlCommand
                ("Update BookingTaskControl Set TaskID=" + UpdatedNumber, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            conn.Close();
        }


        /*! 
        Insert order task details in the database
        */
        public string InsertOrdertask(TaskDetails Task)
        {
            string taskid = OrderTaskID();
            string Message;
            con.Open();
            int TaskID = Convert.ToInt32(taskid);
            TaskID += 1;



            SqlCommand cmd = new SqlCommand("INSERT INTO [OrderTask]([EmpName],[OrderID],[TableNo],[TaskID],[Dates]) values('" + Task.EmpName + "','" + Task.OrderID + "','" + Task.TableNo + "', '" + TaskID + "','" + Task.Dates + "')", con);


            int result = cmd.ExecuteNonQuery();

            if (result == 1)
            {

                Message = "Task details Registered successfully";

            }

            else
            {

                Message = "Task details not Registered successfully";

            }

            con.Close();
            UpdateOrderTaskControl(TaskID);
            return Message;
        }
        /*! 
        Insert order task id automatical into the database
        */
        private string OrderTaskID()
        {
            SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|DorisShisa.mdf;Integrated Security=True");


            SqlCommand cmd = new SqlCommand("Select TaskID from OrderTaskControl", Con);
            Con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return reader["TaskID"].ToString();
            }
            else
            {
                return "Bad Task";
            }

        }
        /*! 
      Update order task id automatical after each order task is assigned
        */
        private void UpdateOrderTaskControl(int UpdatedNumber)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|DorisShisa.mdf;Integrated Security=True");

            SqlCommand cmd = new SqlCommand
                ("Update OrderTaskControl Set TaskID=" + UpdatedNumber, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            conn.Close();
        }

        /*! 
        Insert Assigned task to the booking details, after task has been assigned
        */
        public string InsertAssigned(BookingDetails Bookings)
        {
            string Message;

            if (con.State == ConnectionState.Closed)
            {

                con.Open();

            }

            SqlCommand cmd = new SqlCommand("update Bookings set Assigned=@Assigned where BookingID=@BookingID", con);


            cmd.Parameters.AddWithValue("@Assigned", "YES");
            cmd.Parameters.AddWithValue("@BookingID", Bookings.BookingID);

            int result = cmd.ExecuteNonQuery();

            if (result == 1)
            {

                Message = "changed";

            }

            else
            {

                Message = "could not be Changed";

            }

            con.Close();

            return Message;
        }

        /*! 
       Get booking details from the database to display to the admin
        */

        public DataSet GetBookingDetails(BookingDetails Bookings)
        {
            if (con.State == ConnectionState.Closed)
            {

                con.Open();

            }

            SqlCommand cmd = new SqlCommand("select * from Bookings where BookingID=@BookingID", con);




            cmd.Parameters.AddWithValue("@BookingID", Bookings.BookingID);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds);

            cmd.ExecuteNonQuery();

            con.Close();

            return ds;
        }
        /*! 
       Get order details from the database to display to the admin
        */
        public DataSet GetOrderDetails(OrderDetails OrderTable)
        {
            if (con.State == ConnectionState.Closed)
            {

                con.Open();

            }

            SqlCommand cmd = new SqlCommand("select * from OrderTable where OrderID=@OrderID", con);




            cmd.Parameters.AddWithValue("@OrderID", OrderTable.OrderID);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds);

            cmd.ExecuteNonQuery();

            con.Close();

            return ds;
        }

        /*! 
        Insert Assigned in the order details, after order has been assigned
        */
        public string InsertTaskAssigned(OrderDetails OrderTable)
        {
            string Message;

            if (con.State == ConnectionState.Closed)
            {

                con.Open();

            }

            SqlCommand cmd = new SqlCommand("update OrderTable set Assigned=@Assigned where OrderID=@OrderID", con);


            cmd.Parameters.AddWithValue("@Assigned", "YES");
            cmd.Parameters.AddWithValue("@OrderID", OrderTable.OrderID);

            int result = cmd.ExecuteNonQuery();

            if (result == 1)
            {

                Message = "changed";

            }

            else
            {

                Message = "could not be changed";

            }

            con.Close();

            return Message;
        }

        /*! 
       Get booking task details from the database to display for the admin
        */
        public DataSet GetBookingTAskDetails(TaskDetails BookingTask)
        {
            if (con.State == ConnectionState.Closed)
            {

                con.Open();

            }

            SqlCommand cmd = new SqlCommand("select * from BookingTask where TaskID=@TaskID", con);




            cmd.Parameters.AddWithValue("@TaskID", BookingTask.TaskID);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds);

            cmd.ExecuteNonQuery();

            con.Close();

            return ds;
        }
        /*! 
        Get order task details from the database to display to the admin
        */
        public DataSet GetOrderTaskDetails(TaskDetails OrderTask)
        {
            if (con.State == ConnectionState.Closed)
            {

                con.Open();

            }

            SqlCommand cmd = new SqlCommand("select * from OrderTask where TaskID=@TaskID", con);




            cmd.Parameters.AddWithValue("@TaskID", OrderTask.TaskID);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds);

            cmd.ExecuteNonQuery();

            con.Close();

            return ds;
        }

        /*! 
       Delete booking task details from the booking task table in the database
        */
        public bool DeleteBookingTAskDetails(TaskDetails BookingTask)
        {
            if (con.State == ConnectionState.Closed)
            {

                con.Open();

            }

            SqlCommand cmd = new SqlCommand("delete from BookingTask where TaskID=@TaskID", con);




            cmd.Parameters.AddWithValue("@TaskID", BookingTask.TaskID);

            cmd.ExecuteNonQuery();

            con.Close();

            return true;
        }
        /*! 
      Delete order task details from the order task table in the database
       */
        public bool DeleteOrderTaskDetails(TaskDetails OrderTask)
        {
            if (con.State == ConnectionState.Closed)
            {

                con.Open();

            }

            SqlCommand cmd = new SqlCommand("delete from OrderTask where TaskID=@TaskID", con);




            cmd.Parameters.AddWithValue("@TaskID", OrderTask.TaskID);

            cmd.ExecuteNonQuery();

            con.Close();

            return true;
        }

        /*! 
    Update booking task details from the booking task table in the database
       */
        public string UpdateBookingTAskDetails(TaskDetails BookingTask)
        {
            string Message;

            if (con.State == ConnectionState.Closed)
            {

                con.Open();

            }

            SqlCommand cmd = new SqlCommand("update BookingTask set EmpName=@EmpName,TableNo=@TableNo where TaskID=@TaskID", con);


            cmd.Parameters.AddWithValue("@TaskID", BookingTask.TaskID);
            cmd.Parameters.AddWithValue("@EmpName", BookingTask.EmpName);
            cmd.Parameters.AddWithValue("@TableNo", BookingTask.TableNo);
            
            int result = cmd.ExecuteNonQuery();

            if (result == 1)
            {

                Message = "Record updated successfully";

            }

            else
            {

                Message = "Record could not be updated";

            }

            con.Close();

            return Message;
        }
        /*! 
      Update order task details from the order task table in the database
       */
        public string UpdateOrderTaskDetails(TaskDetails OrderTask)
        {
            string Message;

            if (con.State == ConnectionState.Closed)
            {

                con.Open();

            }

            SqlCommand cmd = new SqlCommand("update OrderTask set EmpName=@EmpName,TableNo=@TableNo where TaskID=@TaskID", con);


            cmd.Parameters.AddWithValue("@TaskID", OrderTask.TaskID);
            cmd.Parameters.AddWithValue("@EmpName", OrderTask.EmpName);
            cmd.Parameters.AddWithValue("@TableNo", OrderTask.TableNo);

            int result = cmd.ExecuteNonQuery();

            if (result == 1)
            {

                Message = "Record updated successfully";

            }

            else
            {

                Message = "Record could not be updated";

            }

            con.Close();

            return Message;
        }

        /*! 
     Insert page visits  in the database from page visits visitors
       */
        public string InsertPageVisit(PageVisit PageVisitTable)
        {
            string Message;

            if (con.State == ConnectionState.Closed)
            {

                con.Open();

            }

            SqlCommand cmd = new SqlCommand("update PageVisitTable set NumberOfVisits +=1 where PageName=@PageName", con);


            cmd.Parameters.AddWithValue("@PageName", PageVisitTable.PageName);
            cmd.Parameters.AddWithValue("@NumberOfVisits", PageVisitTable.NumberOfVisits);
            

            int result = cmd.ExecuteNonQuery();

            if (result == 1)
            {

                Message = "Hit successfully";

            }

            else
            {

                Message = "Hit not be updated";

            }

            con.Close();

            return Message;

        }

        /*! 
     Insert activity logs in the database from customer activity logs in Applications
       */
        public string InsertActivityLogs(ActivityLogs ActivityTable)
        {
            string Message;
            con.Open();

            DateTime date = DateTime.Parse(DateTimeOffset.Now.ToString());

            SqlCommand command = new SqlCommand("INSERT INTO [ActivityTable] ([Email],[Activity],[ActivityDate])Values ('" + ActivityTable.Email + "', '" + ActivityTable.Activity + "','" + date + "')", con);

            int result = command.ExecuteNonQuery();

            if (result == 1)
            {

                Message = " Details Registered successfully";

            }

            else
            {

                Message ="Details not Registered successfully";

            }

            con.Close();

            return Message;
        }

        /*! 
     Get Webusers details to display to each customer after logging in
       */
        public WebUsers GetCusEmail(string Email)
        {
            con.Open();

            var Cmd = new SqlCommand();

            Cmd.Connection = con;

            Cmd.CommandText = "Select * from WebUsers where Email=@Email";

            Cmd.Parameters.AddWithValue("@Email", Email);



            var Reader = Cmd.ExecuteReader();



            WebUsers webusers = new WebUsers();



            while (Reader.Read())
            {

                webusers.Email = Reader["Email"].ToString();

                webusers.Name = Reader["Name"].ToString();

                webusers.Surname = Reader["Surname"].ToString();

                webusers.Cell = Reader["Cell"].ToString();

               webusers.Password =Reader["Password"].ToString();
               webusers.UserLevel = Reader["UserLevel"].ToString();

             
            }

            Reader.Close();

            con.Close();

            return webusers;
        }

        /*! 
     Get order details from the order table to display to each customer order details
       */
        public OrderDetails GetuserOrderDetails(string Email)
        {
            con.Open();

            var Cmd = new SqlCommand();

            Cmd.Connection = con;

            Cmd.CommandText = "Select * from OrderTable where Email=@Email";

            Cmd.Parameters.AddWithValue("@Email", Email);



            var Reader = Cmd.ExecuteReader();



            OrderDetails OrderTable = new OrderDetails();



            while (Reader.Read())
            {

                OrderTable.CustomerEmail = Reader["Email"].ToString();

                OrderTable.OrderID = int.Parse(Reader["OrderID"].ToString());

                OrderTable.ProductID = Reader["ProductID"].ToString();

                OrderTable.ProductName = Reader["ProductName"].ToString();

                OrderTable.ProductPrice = Reader["ProductPrice"].ToString();
              

            }

            Reader.Close();

            con.Close();

            return OrderTable;
        }

        /*! 
     Get order details from the database, for the customer to view their order details
       */
        public DataSet Vieworder(OrderDetails OrderTable)
        {
            if (con.State == ConnectionState.Closed)
            {

                con.Open();

            }

            SqlCommand cmd = new SqlCommand("select * from OrderTable where Email=@Email", con);
            cmd.Parameters.AddWithValue("@Email", OrderTable.CustomerEmail);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds);

            cmd.ExecuteNonQuery();

            con.Close();

            return ds;
        }

        /*! 
Insert subscription numbers in the database 
*/
      
           
        public string SubscriptionsReport(ReportDetails Report)
        {
            string Message;

            if (con.State == ConnectionState.Closed)
            {

                con.Open();

            }

            SqlCommand cmd = new SqlCommand("update SubscriptionReport set NumberOfSubscription +=1 where SubscriptionDate=@SubscriptionDate", con);


            cmd.Parameters.AddWithValue("@SubscriptionDate", "10/17/2013");
            cmd.Parameters.AddWithValue("@NumberOfSubscription", Report.Number);


            int result = cmd.ExecuteNonQuery();

            if (result == 1)
            {

                Message = "Hit successfully";

            }

            else
            {

                Message = "Hit not be updated";

            }

            con.Close();

            return Message;
        }

        public string BookingReport(ReportDetails Report)
        {
            string Message;

            if (con.State == ConnectionState.Closed)
            {

                con.Open();

            }

            SqlCommand cmd = new SqlCommand("update BookingReport set NumberOfBooking +=1 where BookingDate=@BookingDate", con);


            cmd.Parameters.AddWithValue("@BookingDate", "10/17/2013");
            cmd.Parameters.AddWithValue("@NumberOfBooking", Report.Number);


            int result = cmd.ExecuteNonQuery();

            if (result == 1)
            {

                Message = "Hit successfully";

            }

            else
            {

                Message = "Hit not be updated";

            }

            con.Close();

            return Message;
        }


        public string OrderReport(ReportDetails Report)
        {
            string Message;

            if (con.State == ConnectionState.Closed)
            {

                con.Open();

            }

            SqlCommand cmd = new SqlCommand("update OrderReport set NumberOfOrder +=1 where OrderDate=@OrderDate", con);


            cmd.Parameters.AddWithValue("@OrderDate", "10/17/2013");
            cmd.Parameters.AddWithValue("@NumberOfOrder", Report.Number);


            int result = cmd.ExecuteNonQuery();

            if (result == 1)
            {

                Message = "Hit successfully";

            }

            else
            {

                Message = "Hit not updated";

            }

            con.Close();

            return Message;
        }

        public List<OrderDetails>GetProductName(string Email)
        {
            List<OrderDetails>Orderdetails = new List<OrderDetails>();
          SqlConnection  conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|DorisShisa.mdf;Integrated Security=True");
      
            string comstr = "";

            comstr = "SELECT * FROM [OrderTable] WHERE Email ='" + Email + "';";
           SqlCommand commnd = new SqlCommand(comstr);
            commnd.CommandType = CommandType.Text;
            commnd.Connection = conn;
            commnd.Connection.Open();
            commnd.ExecuteNonQuery();
            SqlDataReader reader = commnd.ExecuteReader(CommandBehavior.CloseConnection);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    OrderDetails Client = new OrderDetails();

                    Client.ProductName = Convert.ToString(reader["ProductName"]);
                    Client.ProductID = Convert.ToString(reader["ProductID"]);
                    Client.ProductPrice = Convert.ToString(reader["ProductPrice"]);
                    Client.OrderDate = Convert.ToDateTime(reader["OrderDate"]);
                    Client.OrderID = Convert.ToInt32(reader["OrderID"]);
                    Orderdetails.Add(Client);
                }
            }
            commnd.Connection.Close();
            return Orderdetails.ToList();
        }



        public OrderDetails GetUserOrderProductDetails(string ProductName)
        {
            con.Open();

            var Cmd = new SqlCommand();

            Cmd.Connection = con;

            Cmd.CommandText = "Select * from OrderTable where ProductName=@ProductName";

            Cmd.Parameters.AddWithValue("@ProductName", ProductName);



            var Reader = Cmd.ExecuteReader();



            OrderDetails OrderTable = new OrderDetails();



            while (Reader.Read())
            {

                OrderTable.CustomerEmail = Reader["Email"].ToString();

                OrderTable.OrderID = int.Parse(Reader["OrderID"].ToString());

                OrderTable.ProductID = Reader["ProductID"].ToString();

                OrderTable.ProductName = Reader["ProductName"].ToString();

                OrderTable.ProductPrice = Reader["ProductPrice"].ToString();


            }

            Reader.Close();

            con.Close();

            return OrderTable;
        }


        public bool DeleteOrder(OrderDetails products)
        {
            if (con.State == ConnectionState.Closed)
            {

                con.Open();

            }

            SqlCommand cmd = new SqlCommand("delete from OrderTable where ProductName=@ProductName", con);




            cmd.Parameters.AddWithValue("@ProductName", products.ProductName);

            cmd.ExecuteNonQuery();

            con.Close();

            return true;
        }
    }
    
    }
    
