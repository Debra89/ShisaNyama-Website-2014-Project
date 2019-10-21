using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DorisShisaWebApplication.ServiceReference1;
namespace DorisShisaWebApplication
{
    public partial class Booking : System.Web.UI.Page
    {/*! 
    allow the visitor to make a booking
       */
        protected void Page_Load(object sender, EventArgs e)
        {
            PageVisit PagevisitTable = new PageVisit();
            PagevisitTable.PageName = "Bookings";
            Service1Client client = new Service1Client();
            string result = client.InsertPageVisit(PagevisitTable);
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
           
            Response.Redirect("ConfirmBooking.aspx?Email=" +
              this.txtemail.Text + "&Name=" +
              this.txtName.Text + "&Cell=" + this.txtphone.Text + "&NumberOfPeople=" + this.Txtnumber.Text + "&Dates=" + txtDOB.Text + "&Times=" + this.txttime.Text + "&Request=" + this.txtRequest.Text);
           
        }
    }
}