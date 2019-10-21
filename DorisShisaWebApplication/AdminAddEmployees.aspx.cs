using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Drawing;
using DorisShisaWebApplication.ServiceReference1;
namespace DorisShisaWebApplication
{
    public partial class AdminAddEmployees : System.Web.UI.Page
    { /*! 
    Allow the admin to add employees to the database
       */
        public static String autoPassword = AutoGeneratePassword.generatePassword();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
               


            }
            if (Session["authenticated"] == null)
            {
                Response.Redirect("Login.aspx");
            }
           
        }

        protected void cmdCreateUser_Click(object sender, EventArgs e)
        {
            WebUsers WebUsers = new WebUsers();


            WebUsers.Surname = txtsurname.Text;
            WebUsers.Name = txtname.Text;
            WebUsers.Cell = txtcell.Text;
            WebUsers.Email = txtemail.Text;
            WebUsers.Password = autoPassword;
            WebUsers.UserLevel ="2";
            Service1Client client = new Service1Client();

            string result = client.InsertUserDetails(WebUsers);

            lblStatus.Text = result;
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
        

        protected void chkMailNotifyAdd_CheckedChanged(object sender, EventArgs e)
        {this.chkMailNotifyAdd.Text = this.chkMailNotifyAdd.Text;

           try
            {
                MailMessage Email_Information = new MailMessage();
                Email_Information.To.Add(txtemail.Text.ToString());
                Email_Information.From = new MailAddress("dorisdorah20@gmail.com");
                Email_Information.Subject = (" Welcome " + txtname.Text.ToString() + " ");
                Email_Information.Body = "Your Email is: " + txtemail.Text.ToString() + "<br /><br />Your Password is: " + autoPassword + "<br /><br />";
                Email_Information.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Credentials = new System.Net.NetworkCredential("dorisdorah20@gmail.com", "dorah2nkuna");
                smtp.Send(Email_Information);
                lblMailNotifyAdd.Text = "Password has been sent to the user";
                lblMailNotifyAdd.ForeColor = Color.DarkGreen;
            }
            catch (Exception ex)
            {
                lblMailNotifyAdd.Text = "Password could not be sent to the user" + ex.Message;
                lblMailNotifyAdd.ForeColor = Color.Red;
            }
                            


                            
        }

        }
    }
