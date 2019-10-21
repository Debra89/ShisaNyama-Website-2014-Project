using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DorisShisaWebApplication.ServiceReference1;
namespace DorisShisaWebApplication
{
    public partial class ConfirmBooking : System.Web.UI.Page
    {/*! 
    allow the visitor to make a confirm their booking
       */
        protected void Page_Load(object sender, EventArgs e)
        {
            PageVisit PagevisitTable = new PageVisit();
            PagevisitTable.PageName = "ConfirmBooking";
            Service1Client client = new Service1Client();
            string result = client.InsertPageVisit(PagevisitTable);
           
           
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
      
          
            Bookings.Name = txtName.Text;
            Bookings.Email = txtemail.Text;
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
            Response.Redirect("Default.aspx");
        }
    }
}