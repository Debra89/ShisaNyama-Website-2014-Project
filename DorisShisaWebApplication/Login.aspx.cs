using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DorisShisaWebApplication.ServiceReference1;
namespace DorisShisaWebApplication
{
    public partial class Login : System.Web.UI.Page
    {/*! 
    allow registered webusers to login
       */
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["Email"] = Txtemail.Text.Trim().ToString();
            Txtemail.Focus();

           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            WebUsers WebUsers = new WebUsers();
          
            WebUsers.Email = Txtemail.Text;
            WebUsers.Password = Txtpassword.Text;
            Service1Client msg = new Service1Client();
            string re = msg.logUsers(WebUsers);
            Session["authenticated"] = true;

            Session["Email"] = Txtemail.Text.Trim().ToString();

            if (Session["authenticated"] != null)
            {


                if (re == "Staff")
                {
                    Response.Redirect("AdminHome.aspx");
                }
                else if (re == "Customers")
                {
                    Response.Redirect("CusHome.aspx");
                }
                else if (re == "UserDoesntExist")
                {
                    LabelMessage.Text = "Incorrect username or password";
                    Txtemail.Focus();
                }
                Txtemail.Text = "";
            }
        }
    }
}