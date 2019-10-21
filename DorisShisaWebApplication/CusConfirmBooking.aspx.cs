using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DorisShisaWebApplication.ServiceReference1;
namespace DorisShisaWebApplication
{
    public partial class CusConfirmBooking : System.Web.UI.Page
    {/*! 
    allow the customer to confirm their booking
       */
        protected void Page_Load(object sender, EventArgs e)
        {
           
            ActivityLogs ActivityTable = new ActivityLogs();
            ActivityTable.Activity = "Clicked to confirm a booking";
            Service1Client client = new Service1Client();
            ActivityTable.Email = Session["Email"].ToString();

            string result = client.InsertActivityLogs(ActivityTable);
            
            this.txtemail.Text = Request.QueryString["Email"];
            this.txtName.Text = Request.QueryString["Name"];
            this.txtphone.Text = Request.QueryString["Cell"];
            this.Txtnumber.Text = Request.QueryString["NumberOfPeople"];
            this.txtDOB.Text = Request.QueryString["Dates"];
            this.txttime.Text = Request.QueryString["Times"];
            this.txtRequest.Text = Request.QueryString["Request"];

        }

       

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            ReportDetails Report = new ReportDetails();
            Service1Client client = new Service1Client();
            string results = client.BookingReport(Report);
            BookingDetails Bookings = new BookingDetails();
            WebUsers user = new WebUsers();
            user.Email = Session["Email"].ToString();
            Bookings.Name = txtName.Text;
            Bookings.Email = Session["Email"].ToString();
            Bookings.NumberOfPeople = Txtnumber.Text;
            Bookings.Cell = txtphone.Text;

            Bookings.Dates = DateTime.Parse(txtDOB.Text);

            Bookings.Times = DateTime.Parse(txttime.Text);
            Bookings.Request = txtRequest.Text;


           

            string result = client.bookuser(Bookings);

            lblMsg.Text = result;
            ClearControls(this);
        }




        private void ClearControls(Control ctrl)
        {
            foreach (Control tb in ctrl.Controls)
            {
                if (tb is TextBox)
                {
                    ((TextBox)tb).Text = "";
                }
                else
                {
                    if (tb.Controls.Count > 0)
                    {
                        ClearControls(tb);
                    }
                }
            }
        }

        protected void btncancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("CusHome.aspx");
        }
    }
}