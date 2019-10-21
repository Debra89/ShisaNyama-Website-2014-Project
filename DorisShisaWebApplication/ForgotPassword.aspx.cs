using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DorisShisaWebApplication.ServiceReference1;
using System.Net.Mail;
using System.Drawing;
namespace DorisShisaWebApplication
{
    public partial class ForgotPassword : System.Web.UI.Page
    {/*! 
    allow the visitors who lost their password to recover their passwords
       */
        public static String autoPassword = AutoGeneratePassword.generatePassword();
        protected void Page_Load(object sender, EventArgs e)
        {
            PageVisit PagevisitTable = new PageVisit();
            PagevisitTable.PageName = "ForgotPassword";
            Service1Client client = new Service1Client();
            string result = client.InsertPageVisit(PagevisitTable);
        }

        protected void cmdsubmit_Click(object sender, EventArgs e)
        {
            WebUsers WebUsers = new WebUsers();

            WebUsers.Email = txtemail.Text;
            WebUsers.Cell = txtcell.Text;
            WebUsers.Password = autoPassword;
            Service1Client client = new Service1Client();
            string re = client.ForgotPassword(WebUsers);
            if (re == "")
            {

                try
                {
                    MailMessage Email_Information = new MailMessage();
                    Email_Information.To.Add(txtemail.Text.ToString());
                    Email_Information.From = new MailAddress("dorisdorah20@gmail.com");
                    Email_Information.Subject = (" Welcome " + txtemail.Text.ToString() + " ");
                    Email_Information.Body = "Your Email is: " + txtemail.Text.ToString() + "<br /><br />Your Password is: " + autoPassword + "<br /><br />";
                    Email_Information.IsBodyHtml = true;
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.Credentials = new System.Net.NetworkCredential("dorisdorah20@gmail.com", "dorah2nkuna");
                    smtp.Send(Email_Information);
                    LabelMessage.Text = "Password has been sent to the user";
                    LabelMessage.ForeColor = Color.DarkGreen;
                }
                catch (Exception ex)
                {
                    LabelMessage.Text = "Password could not be sent to the user" + ex.Message;
                    LabelMessage.ForeColor = Color.Red;
                }
            }
            else
            {

                LabelMessage.Text = "your email or contact number  does not exist";


            }



            txtemail.Text = "";
            txtcell.Text = "";
                            

        }
    }
}