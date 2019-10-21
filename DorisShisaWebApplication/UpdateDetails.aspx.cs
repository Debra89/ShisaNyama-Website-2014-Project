using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DorisShisaWebApplication.ServiceReference1;
namespace DorisShisaWebApplication
{
    public partial class UpdateDetails : System.Web.UI.Page
    {/*! 
    allow registered users to update their details
       */
        protected void Page_Load(object sender, EventArgs e)
        {
            ActivityLogs ActivityTable = new ActivityLogs();
            ActivityTable.Activity = "Clicked to update details";
            Service1Client client = new Service1Client();
            ActivityTable.Email = Session["Email"].ToString();
            
            string result = client.InsertActivityLogs(ActivityTable);
            if (!IsPostBack)
                ShowInfo();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            WebUsers WebUsers = new WebUsers();

            WebUsers.Email = Session["Email"].ToString();
            WebUsers.Name = txtname.Text;
            WebUsers.Surname = txtsurname.Text;
            WebUsers.Cell = txtmobile.Text;
            Service1Client client = new Service1Client();
            string re  = client.UpdateUserRegDetails(WebUsers);
            LabelMessage.Text = re;
        }
        void ShowInfo()
        {
            WebUsers user = new WebUsers();
            user.Email = Session["Email"].ToString();
            Service1Client cl = new Service1Client();
            user = cl.Select(user);
          
            txtsurname.Text = user.Surname;
            txtmobile.Text = user.Cell;
            txtname.Text = user.Name;
            txtemail.Text = user.Email;
        }

        }
    }
