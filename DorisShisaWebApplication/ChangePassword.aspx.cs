using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DorisShisaWebApplication.ServiceReference1;
namespace DorisShisaWebApplication
{
    public partial class ChangePassword : System.Web.UI.Page
    {/*! 
    allow the customer to change their passwords
       */
        protected void Page_Load(object sender, EventArgs e)
        {
            ActivityLogs ActivityTable = new ActivityLogs();
            ActivityTable.Activity = "Clicked to change password";
            Service1Client client = new Service1Client();
           
            ActivityTable.Email = Session["Email"].ToString();
            
            string result = client.InsertActivityLogs(ActivityTable);
            
            if (!IsPostBack)
                ShowInfo();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
          WebUsers WebUsers = new WebUsers();

            WebUsers.Email = Session["Email"].ToString();

            WebUsers.Password = txtNewPwd.Text;
            Service1Client client = new Service1Client();
            string re = client.ChangePassword(WebUsers);
            lblStatus.Text = re;
        }
        void ShowInfo()
        {
            WebUsers user = new WebUsers();
            user.Email = Session["Email"].ToString();
            Service1Client cl = new Service1Client();
            user = cl.Select(user);

            txtemail.Text = user.Email;

        }


        }
    }
