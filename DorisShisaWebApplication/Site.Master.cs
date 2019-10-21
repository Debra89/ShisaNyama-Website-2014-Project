using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using DorisShisaWebApplication.ServiceReference1;
namespace DorisShisaWebApplication
{
    public partial class SiteMaster : MasterPage
    {/*! 
   this is the site master which hold all the visitor pages
       */
        private const string AntiXsrfTokenKey = "__AntiXsrfToken";
        private const string AntiXsrfUserNameKey = "__AntiXsrfUserName";
        private string _antiXsrfTokenValue;

        protected void Page_Init(object sender, EventArgs e)
        {
            // The code below helps to protect against XSRF attacks
            var requestCookie = Request.Cookies[AntiXsrfTokenKey];
            Guid requestCookieGuidValue;
            if (requestCookie != null && Guid.TryParse(requestCookie.Value, out requestCookieGuidValue))
            {
                // Use the Anti-XSRF token from the cookie
                _antiXsrfTokenValue = requestCookie.Value;
                Page.ViewStateUserKey = _antiXsrfTokenValue;
            }
            else
            {
                // Generate a new Anti-XSRF token and save to the cookie
                _antiXsrfTokenValue = Guid.NewGuid().ToString("N");
                Page.ViewStateUserKey = _antiXsrfTokenValue;

                var responseCookie = new HttpCookie(AntiXsrfTokenKey)
                {
                    HttpOnly = true,
                    Value = _antiXsrfTokenValue
                };
                if (FormsAuthentication.RequireSSL && Request.IsSecureConnection)
                {
                    responseCookie.Secure = true;
                }
                Response.Cookies.Set(responseCookie);
            }

            Page.PreLoad += master_Page_PreLoad;
        }

        protected void master_Page_PreLoad(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Set Anti-XSRF token
                ViewState[AntiXsrfTokenKey] = Page.ViewStateUserKey;
                ViewState[AntiXsrfUserNameKey] = Context.User.Identity.Name ?? String.Empty;
            }
            else
            {
                // Validate the Anti-XSRF token
                if ((string)ViewState[AntiXsrfTokenKey] != _antiXsrfTokenValue
                    || (string)ViewState[AntiXsrfUserNameKey] != (Context.User.Identity.Name ?? String.Empty))
                {
                    throw new InvalidOperationException("Validation of Anti-XSRF token failed.");
                }
            }
        }
        Service1Client client = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ReportDetails Report = new ReportDetails();
            
            string results = client.SubscriptionsReport(Report);

            SubscriptionDetails Subscribe = new SubscriptionDetails();


            Subscribe.Email = txtemail.Text;
           
          
            string result = client.InsertSubscriptions(Subscribe);
            if (result == "")
            {
                LabelMessage.Text = "you have successfully registered, everytime we have sale will notify you";
            }
            else
            {

                LabelMessage.Text = "your registration was unsuccessfully registered";


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