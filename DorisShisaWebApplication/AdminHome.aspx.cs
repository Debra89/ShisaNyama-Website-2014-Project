using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DorisShisaWebApplication
{
    public partial class AdminHome : System.Web.UI.Page
    { /*! 
   the admin get into this page after logging in
       */
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["authenticated"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                Label2.Text = Session["Email"].ToString();
                Label3.Text = Session["Email"].ToString();
            }
        }
    }
}