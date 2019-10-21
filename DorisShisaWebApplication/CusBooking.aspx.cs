using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DorisShisaWebApplication.ServiceReference1;
namespace DorisShisaWebApplication
{
    public partial class CusBooking : System.Web.UI.Page
    {/*! 
    allow the customer to make a booking
       */
        protected void Page_Load(object sender, EventArgs e)
        {
            ActivityLogs ActivityTable = new ActivityLogs();
            ActivityTable.Activity = "Clicked to make a booking";
            Service1Client client = new Service1Client();
            ActivityTable.Email = Session["Email"].ToString();
            
            string result = client.InsertActivityLogs(ActivityTable);
            if (Session["authenticated"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                if (!IsPostBack)
                    ShowInfo();
            }


        }
        void ShowInfo()
        {
            WebUsers user = new WebUsers();
            user.Email = Session["Email"].ToString();
            Service1Client cl = new Service1Client();
            user = cl.Select(user);


            txtphone.Text = user.Cell;
            txtName.Text = user.Name;
            txtemail.Text = user.Email;
       }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
           
        Response.Redirect("CusConfirmBooking.aspx?Email=" +
               this.txtemail.Text + "&Name=" +
               this.txtName.Text + "&Cell=" + this.txtphone.Text + "&NumberOfPeople=" + this.Txtnumber.Text + "&Dates=" + txtDOB.Text + "&Times=" + this.txttime.Text + "&Request=" + this.txtRequest.Text);
      
           
        }
        }
    }
