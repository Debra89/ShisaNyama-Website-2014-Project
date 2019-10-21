using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DorisShisaWebApplication.ServiceReference1;
namespace DorisShisaWebApplication
{/*! 
    allow logged in users to logout
       */
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ActivityLogs ActivityTable = new ActivityLogs();
            ActivityTable.Activity = "Clicked to logout";

            ActivityTable.Email = Session["Email"].ToString();
            Service1Client client = new Service1Client();

            string result = client.InsertActivityLogs(ActivityTable);
            Response.Redirect("Login.aspx");
        }
    }
}