using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DorisShisaWebApplication.ServiceReference1;
namespace DorisShisaWebApplication
{
    public partial class Register : System.Web.UI.Page
    {/*! 
    allow visitors to register to access the website
       */
        protected void Page_Load(object sender, EventArgs e)
        {
            PageVisit PagevisitTable = new PageVisit();
            PagevisitTable.PageName = "Register";
            Service1Client client = new Service1Client();
            string result = client.InsertPageVisit(PagevisitTable);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            WebUsers WebUsers = new WebUsers();


            WebUsers.Surname = txtsurname.Text;
            WebUsers.Name = txtname.Text;
            WebUsers.Cell = txtmobile.Text;
            WebUsers.Email = txtemail.Text;
            WebUsers.Password = txtPass.Text;
            WebUsers.UserLevel = "3";
            Service1Client client = new Service1Client();

            string result = client.InsertUserDetails(WebUsers);
            if (result == "")
            {
                LabelMessage.Text = WebUsers.Name + " congratulations you have successfully registered now you can login";
                Response.Redirect("CusHome.aspx");
            }
            else
            {

                LabelMessage.Text = WebUsers.Name + "your registration was unsuccessfully registered";
               

            }
            LabelMessage.Text = result;
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
    }
}