using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DorisShisaWebApplication.ServiceReference1;
using System.Net.Mail;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
using System.Drawing;
namespace DorisShisaWebApplication
{
    public partial class AdminAssignBookingTask : System.Web.UI.Page
    { /*! 
    Allow the admin to assignbooking task to the customers who made a booking 
       */
        Service1Client client = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /*! 
    send task to the employee
       */
        protected void chkMailNotifyAdd_CheckedChanged(object sender, EventArgs e)
        {
           this.chkMailNotifyAdd.Text = this.chkMailNotifyAdd.Text;

           
            try
            {
                MailMessage Email_Information = new MailMessage();
                Email_Information.To.Add(DropDownList1.SelectedItem.Value.ToString());
                Email_Information.From = new MailAddress("dorisdorah20@gmail.com");
                Email_Information.Subject = (" you have been assigned to Booking ID:" + txtbooking.Text.ToString() + " ");
                Email_Information.Body = "Your task  is at: " + txtdate.Text.ToString() + "<br /><br />the time is: " + txttime.Text.ToString() + "<br /><br />for table:" + DropDownList2.SelectedItem.Text.ToString() +"<br/><br/>";
                Email_Information.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Credentials = new System.Net.NetworkCredential("dorisdorah20@gmail.com", "dorah2nkuna");
                smtp.Send(Email_Information);
                lblMailNotifyAdd.Text = "Booking Task has been sent to the waitron";
                lblMailNotifyAdd.ForeColor = Color.DarkGreen;
            }
            catch (Exception ex)
            {
                lblMailNotifyAdd.Text = "Booking Task could not be sent to the waitron" + ex.Message;
                lblMailNotifyAdd.ForeColor = Color.Red;
            }
                            
        }


        /*! 
    allow the admin to assign task to the employees and table
       */

        protected void cmdAssign_Click(object sender, EventArgs e)
        {
            BookingDetails Bookings = new BookingDetails();
            Bookings.BookingID = int.Parse(txtbooking.Text.Trim());
            client.InsertAssigned(Bookings);

            lblStatus.Text = client.InsertAssigned(Bookings);
            gvDetails.DataBind();
            if (cmdAssign.Text == "Assign")
            {

                AssignTask();

            }

        }

        private void AssignTask()
        {

            TaskDetails TaskTable = new TaskDetails();
            TaskTable.EmpName = DropDownList1.SelectedItem.Text;
            TaskTable.TableNo = DropDownList2.SelectedItem.Text;

            TaskTable.BookingID = int.Parse(txtbooking.Text.Trim());
            TaskTable.Dates = DateTime.Parse(txtdate.Text.Trim());
            TaskTable.Times = DateTime.Parse(txttime.Text.Trim());
           
          
            client.Insertbookingtask(TaskTable);

            lblStatus.Text = client.Insertbookingtask(TaskTable);

            ClearControls();

            gvDetails.DataBind();



        }

        /*! 
    Allow the admin to update details
       */
        protected void imgEdit_Command(object sender, System.Web.UI.WebControls.CommandEventArgs e)
        {

            BookingDetails Booking = new BookingDetails();

            Booking.BookingID = int.Parse(e.CommandArgument.ToString());

            ViewState["BookingID"] = Booking.BookingID;

            DataSet ds = new DataSet();

            ds = client.GetBookingDetails(Booking);


            if (ds.Tables[0].Rows.Count > 0)
            {

                txtbooking.Text = ds.Tables[0].Rows[0]["BookingID"].ToString();
               
                txtdate.Text = ds.Tables[0].Rows[0]["Dates"].ToString();
                txttime.Text = ds.Tables[0].Rows[0]["Times"].ToString();
                

                cmdAssign.Text = "Assign";

            }

        }
        private void ClearControls()
        {



           

            txtdate.Text = string.Empty;

            txttime.Text = string.Empty;

           

           
            txtbooking.Text = "";

            cmdAssign.Text = "Assign";

           

        }

        /*! 
     send booking details to the customer
       */
        protected void ChkMailNotifyCus_CheckedChanged(object sender, EventArgs e)
        {
            this.ChkMailNotifyCus.Text = this.ChkMailNotifyCus.Text;


            try
            {
                MailMessage Email_Information = new MailMessage();
                Email_Information.To.Add("dorisdorah@ymail.com");
                Email_Information.From = new MailAddress("dorisdorah20@gmail.com");
                Email_Information.Subject = (" your Booking ID is:" + txtbooking.Text.ToString() + " ");
                Email_Information.Body = "Your Ordered for: " + txtdate.Text.ToString() + "<br /><br />the time is: " + txttime.Text.ToString() + "<br /><br />for table:" + DropDownList2.SelectedItem.Text.ToString() + "<br/><br/>";
                Email_Information.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Credentials = new System.Net.NetworkCredential("dorisdorah20@gmail.com", "dorah2nkuna");
                smtp.Send(Email_Information);
                Lblresults.Text = "Booking Task has been sent to the Customer";
                Lblresults.ForeColor = Color.DarkGreen;
            }
            catch (Exception ex)
            {
                Lblresults.Text = "Booking  could not be sent to the Customer" + ex.Message;
                Lblresults.ForeColor = Color.Red;
            }
        }
    }
}