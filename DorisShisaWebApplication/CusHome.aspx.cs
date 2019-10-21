using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DorisShisaWebApplication.ServiceReference1;
namespace DorisShisaWebApplication
{
    public partial class CusHome : System.Web.UI.Page
    {/*! 
  after logging in the customers get to this page
       */
        protected void Page_Load(object sender, EventArgs e)

        {
            ActivityLogs ActivityTable = new ActivityLogs();
            ActivityTable.Activity = "Clicked to login";

            ActivityTable.Email = Session["Email"].ToString();
            Service1Client client = new Service1Client();

            string result = client.InsertActivityLogs(ActivityTable);
            Session["currentyearz"] = DateTimeOffset.Now.Year.ToString();
            
            ///<Navigate to login page if user login session is empty>
        if (Session["authenticated"] == null)
        {
            Response.Redirect("Login.aspx");
        }
        else
        {
            Label2.Text = Session["Email"].ToString();
            Label3.Text = Session["Email"].ToString();
        }

        if (!Page.IsPostBack)
        {
        }

        }
    }
}