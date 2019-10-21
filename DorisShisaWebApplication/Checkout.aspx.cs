using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DorisShisaWebApplication.ServiceReference1;
namespace DorisShisaWebApplication
{
    public partial class Checkout : System.Web.UI.Page
    {/*! 
    allow the customer to check out after placing an order for food
       */
        protected void Page_Load(object sender, EventArgs e)
        {
            ActivityLogs ActivityTable = new ActivityLogs();
            ActivityTable.Activity = "Clicked to view order";
            Service1Client client = new Service1Client();
            ActivityTable.Email = Session["Email"].ToString();
           
            string result = client.InsertActivityLogs(ActivityTable);
        }
    }
}