using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DorisShisaWebApplication.ServiceReference1;
namespace DorisShisaWebApplication
{
    public partial class CusPromotionsDetails : System.Web.UI.Page
    {/*! 
    allow the customer to view products details after viewing the promotion
       */
        protected void Page_Load(object sender, EventArgs e)
        {
            ActivityLogs ActivityTable = new ActivityLogs();
            ActivityTable.Activity = "Clicked to view promotion details";
            Service1Client client = new Service1Client();
            ActivityTable.Email = Session["Email"].ToString();
           
            string result = client.InsertActivityLogs(ActivityTable);
        }
    }
}