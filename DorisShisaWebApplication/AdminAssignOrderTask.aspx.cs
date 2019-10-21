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
    public partial class AdminAssignOrderTask : System.Web.UI.Page
    { /*! 
    Allow the admin to assign order task to the orders placed
       */
        Service1Client client = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void chkMailNotifyAdd_CheckedChanged(object sender, EventArgs e)
        {
            this.chkMailNotifyAdd.Text = this.chkMailNotifyAdd.Text;


            try
            {
                MailMessage Email_Information = new MailMessage();
                Email_Information.To.Add(DropDownList1.SelectedItem.Value.ToString());
                Email_Information.From = new MailAddress("dorisdorah20@gmail.com");
                Email_Information.Subject = (" you have been assigned to Order ID:" + txtorder.Text.ToString() + " ");
                Email_Information.Body = "Your task  is at: " + txtdate.Text.ToString() + "<br /><br /> for table:" + DropDownList2.SelectedItem.Text.ToString() + "<br/><br/>";
                Email_Information.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Credentials = new System.Net.NetworkCredential("dorisdorah20@gmail.com", "dorah2nkuna");
                smtp.Send(Email_Information);
                lblMailNotifyAdd.Text = "Order Task has been sent to the waitron";
                lblMailNotifyAdd.ForeColor = Color.DarkGreen;
            }
            catch (Exception ex)
            {
                lblMailNotifyAdd.Text = "Order Task could not be sent to the waitron" + ex.Message;
                lblMailNotifyAdd.ForeColor = Color.Red;
            }
                            
        }

        protected void cmdAssign_Click(object sender, EventArgs e)
        {
            OrderDetails Order = new OrderDetails();
            Order.OrderID = int.Parse(txtorder.Text.Trim());
            client.InsertTaskAssigned(Order);

            lblStatus.Text = client.InsertTaskAssigned(Order);
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

            TaskTable.OrderID = int.Parse(txtorder.Text.Trim());
            TaskTable.Dates = DateTime.Parse(txtdate.Text.Trim());
           

            client.InsertOrdertask(TaskTable);

            lblStatus.Text = client.InsertOrdertask(TaskTable);

            ClearControls();

            gvDetails.DataBind();

        }
        protected void imgEdit_Command(object sender, System.Web.UI.WebControls.CommandEventArgs e)
        {

            OrderDetails Order = new OrderDetails();

            Order.OrderID = int.Parse(e.CommandArgument.ToString());

            ViewState["OrderID"] = Order.OrderID;

            DataSet ds = new DataSet();

            ds = client.GetOrderDetails(Order);


            if (ds.Tables[0].Rows.Count > 0)
            {

                txtorder.Text = ds.Tables[0].Rows[0]["OrderID"].ToString();
                //txtproduct.Text = ds.Tables[0].Rows[0]["ProductName"].ToString();
                txtdate.Text = ds.Tables[0].Rows[0]["OrderDate"].ToString();   
                //txtname.Text = ds.Tables[0].Rows[0]["CustomerEmail"].ToString();


                cmdAssign.Text = "Assign";

            }

        }
        private void ClearControls()
        {



            
            txtdate.Text = string.Empty;

           

            txtorder.Text = string.Empty;

          
            cmdAssign.Text = "Assign";

            
        }

        protected void ChkMailNotifyCus_CheckedChanged(object sender, EventArgs e)
        {
            this.ChkMailNotifyCus.Text = this.ChkMailNotifyCus.Text;


            try
            {
                MailMessage Email_Information = new MailMessage();
                Email_Information.To.Add("dorisdorah@ymail.com");
                Email_Information.From = new MailAddress("dorisdorah20@gmail.com");
                Email_Information.Subject = (" your Order ID is:" + txtorder.Text.ToString() + " ");
                Email_Information.Body = "Your Order  is at: " + txtdate.Text.ToString() + "<br /><br /> for table:" + DropDownList2.SelectedItem.Text.ToString() + "<br/><br/>";
                Email_Information.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Credentials = new System.Net.NetworkCredential("dorisdorah20@gmail.com", "dorah2nkuna");
                smtp.Send(Email_Information);
                lblMailNotifyAdd.Text = "Order Task has been sent to the Customer";
                lblMailNotifyAdd.ForeColor = Color.DarkGreen;
            }
            catch (Exception ex)
            {
                Lblresults.Text = "Order Task could not be sent to the customer" + ex.Message;
                Lblresults.ForeColor = Color.Red;
            }
                            
        }
    }
}