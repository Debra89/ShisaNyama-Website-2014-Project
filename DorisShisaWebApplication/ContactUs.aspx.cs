using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using DorisShisaWebApplication.ServiceReference1;
namespace DorisShisaWebApplication
{
    public partial class ContactUs : System.Web.UI.Page
    {/*! 
    allow the visitor to contact us
       */
        protected void Page_Load(object sender, EventArgs e)
        {
            PageVisit PagevisitTable = new PageVisit();
            PagevisitTable.PageName = "ContactUs";
            Service1Client client = new Service1Client();
            string result = client.InsertPageVisit(PagevisitTable);
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (true)
            {
                MailMessage loginInfo = new MailMessage();
                loginInfo.To.Add("dorisdorah@ymail.com".ToString());
                loginInfo.To.Add("sishanyama123@gmail.com".ToString());
                loginInfo.From = new MailAddress("dorisdorah20@gmail.com");
                loginInfo.Subject = txtSubject.Text;


                loginInfo.Body = "From: " + txtName.Text + "<br> <br> Email: " + txtEmail.Text + "<br> <br> Subject: " + txtSubject.Text + " <br><br>Message: " + txtMessage.Text + "<br><br>";
                loginInfo.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Credentials = new System.Net.NetworkCredential("dorisdorah20@gmail.com", "dorah2nkuna");
                smtp.Send(loginInfo);
                lbltxt.Text = "Thank you for Contacting us";
            }


            try
            {

                txtSubject.Text = "";
                txtEmail.Text = "";
                txtName.Text = "";
                txtMessage.Text = "";

            }

            catch (Exception ex)
            {

                Console.WriteLine("{0} Exception caught.", ex);

            }

        }
    }
}